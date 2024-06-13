using COFFE_SHARP.Models;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFE_SHARP.View
{
    public partial class QRIS : Form
    {
        string kode_qr = "https://hampton-mode-troubleshooting-bold.trycloudflare.com";
        private static readonly HttpClient client = new HttpClient();
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        private int IDMetode;
        UCTransaksi ucTransaksi;
        private decimal jumlahPembayaran;
        private Pembayaran pembayaran;

        public QRIS(int iDMetode, UCTransaksi ucTransaksi)
        {
            InitializeComponent();
            Task.Run(() => MonitorCloseFlag(cancellationTokenSource.Token));
            this.IDMetode = iDMetode;
            this.ucTransaksi = ucTransaksi;
            this.FormClosing += QRIS_FormClosing;
        }

        private async Task MonitorCloseFlag(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    var response = await client.GetStringAsync(kode_qr + "/check");
                    dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(response);
                    bool closeFlag = json.close_flag;

                    if (closeFlag)
                    {
                        jumlahPembayaran = ucTransaksi.GetTotalHarga();
                        MessageBox.Show("Pembayaran Berhasil ;)", "Pembayaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Invoke(new System.Action(() => this.Close()));
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                await Task.Delay(1000, cancellationToken);
            }
        }

        private void QRIS_Load(object sender, EventArgs e)
        {
            string url_trigger = kode_qr + "/set";
            QRCoder.QRCodeGenerator qr_baru = new QRCoder.QRCodeGenerator();
            var Data_qr = qr_baru.CreateQrCode(url_trigger, QRCodeGenerator.ECCLevel.H);
            var QR = new QRCoder.QRCode(Data_qr);
            pictQRIS.Image = QR.GetGraphic(100);
        }

        private void QRIS_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (jumlahPembayaran > 0)
            {
                ucTransaksi.SimpanTransaksi(IDMetode, jumlahPembayaran);
            }
            Struk struk = new Struk(pembayaran);
            struk.Show();
        }
    }
}
