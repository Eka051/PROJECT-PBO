using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xendit.net;
using System.Text.Json;
using COFFE_SHARP.Models;

namespace COFFE_SHARP.View
{
    public partial class MetodePembayaran : Form
    {
        private List<DetailTransaksi> keranjang;
        private int idAdmin;
        private HttpListener listener;
        private readonly XenditService xenditService;
        private readonly TransaksiContext transaksiContext;
        private QRIS qris;
        private const string XenditWebhookVerificationToken = "ZWXIqwlQN39FZPRf4QgLS8p6SmTrkVismmpMO1JIUFVHRpLy";
        private const string NgrokUrl = "http://localhost:4040/api/tunnels"; // Ngrok URL

        public MetodePembayaran(List<DetailTransaksi> keranjang, int idAdmin)
        {
            InitializeComponent();
            this.keranjang = keranjang;
            this.idAdmin = idAdmin;
            xenditService = new XenditService();
            transaksiContext = new TransaksiContext();
            qris = new QRIS(); // Initialize QRIS
            StartHttpListener();
        }

        private async void StartHttpListener()
        {
            listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8080/"); // Localhost URL
            listener.Start();
            await Task.Run(() => ListenForCallback());

            // Start Ngrok tunnel
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(NgrokUrl);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                var ngrokTunnel = JsonSerializer.Deserialize<NgrokTunnel>(responseBody);
                if (ngrokTunnel != null)
                {
                    Console.WriteLine("Ngrok tunnel started: " + ngrokTunnel.PublicUrl);
                }
            }
        }

        private async void ListenForCallback()
        {
            while (listener.IsListening)
            {
                var context = await listener.GetContextAsync();
                var request = context.Request;
                var response = context.Response;

                if (request.HttpMethod == "POST")
                {
                    using (var reader = new StreamReader(request.InputStream))
                    {
                        var body = await reader.ReadToEndAsync();

                        if (!VerifyWebhookToken(request.Headers["X-Xendit-Webhook-Token"]))
                        {
                            Console.WriteLine("Invalid Xendit Webhook Token");
                            continue;
                        }

                        var callbackRequest = JsonSerializer.Deserialize<XenditCallbackRequest>(body);
                        if (callbackRequest != null && callbackRequest.Status == "COMPLETED")
                        {
                            SaveTransaction(callbackRequest);
                        }
                    }
                    var responseString = "OK";
                    var buffer = Encoding.UTF8.GetBytes(responseString);
                    response.ContentLength64 = buffer.Length;
                    response.OutputStream.Write(buffer, 0, buffer.Length);
                    response.OutputStream.Close();
                }
            }
        }

        public void btnBayar_Click(object sender, EventArgs e)
        {
            List<DetailTransaksi> pembayaran = keranjang;

            if (pembayaran.Count == 0)
            {
                MessageBox.Show("Silakan pilih item untuk dibayar terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Task.Run(async () =>
            {
                try
                {
                    var qrCodeResponse = await xenditService.CreateQrisPayment(pembayaran);
                    if (qrCodeResponse != null)
                    {
                        MessageBox.Show("Pembayaran berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        qris.GenerateQRCode(qrCodeResponse.CheckoutUrl);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }

        private bool VerifyWebhookToken(string webhookToken)
        {
            return webhookToken == XenditWebhookVerificationToken;
        }

        private void SaveTransaction(XenditCallbackRequest callbackRequest)
        {
            Transaksi transaksi = new Transaksi
            {
                TanggalTransaksi = DateTime.Now,
                IdPembayaran = 2,
                DetailTransaksiList = keranjang
            };

            transaksiContext.SimpanTransaksi(transaksi);
            MessageBox.Show("Transaksi berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}