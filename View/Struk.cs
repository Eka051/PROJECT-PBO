using COFFE_SHARP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFE_SHARP.View
{
    public partial class Struk : Form
    {
        private Transaksi newTransaksi;
        private TransaksiContext transaksiContext;
        private Tunai tunai;
        private int IDMetode;
        private int idAdmin = SessionInfo.idAdmin;
        private UCTransaksi uCTransaksi;
        private Pembayaran pembayaran;
        private Bitmap memoryImage;

        public Struk(Pembayaran pembayaran)
        {
            InitializeComponent();
            transaksiContext = new TransaksiContext();
            tunai = new Tunai(IDMetode, uCTransaksi);
            this.pembayaran = pembayaran;
            newTransaksi = transaksiContext.GetLatestTransaksi();
            panelStruk.Size = new Size(733, 820); 

            if (newTransaksi != null)
            {
                labelTanggal.Text = newTransaksi.TanggalTransaksi.ToString("dd/MM/yyyy");
                labelAdmin.Text = newTransaksi.NamaAdmin;
                labelTotalHrg.Text = "Rp. " + newTransaksi.TotalHarga.ToString("N0");

                int yPosition = 307;
                foreach (var detail in newTransaksi.DetailTransaksiList)
                {
                    Produk produk = transaksiContext.GetProdukById(detail.IdProduk);
                    string namaProduk = produk.Nama;
                    Label labelItem = new Label();
                    labelItem.Text = namaProduk;
                    labelItem.Font = new Font("SF Pro Display", 13, FontStyle.Regular);
                    labelItem.Location = new Point(65, yPosition);
                    labelItem.AutoSize = true;
                    panelStruk.Controls.Add(labelItem);

                    Label labelHarga = new Label();
                    labelHarga.Text = detail.HargaProduk.ToString("N0");
                    labelHarga.Font = new Font("SF Pro Display", 13, FontStyle.Regular);
                    labelHarga.Location = new Point(290, yPosition);
                    panelStruk.Controls.Add(labelHarga);

                    Label labelQuantity = new Label();
                    labelQuantity.Text = detail.JumlahProduk.ToString();
                    labelQuantity.Font = new Font("SF Pro Display", 13, FontStyle.Regular);
                    labelQuantity.Location = new Point(459, yPosition);
                    panelStruk.Controls.Add(labelQuantity);

                    Label labelTotal = new Label();
                    labelTotal.Text = (detail.HargaProduk * detail.JumlahProduk).ToString("N0");
                    labelTotal.Font = new Font("SF Pro Display", 13, FontStyle.Regular);
                    labelTotal.Location = new Point(585, yPosition);
                    panelStruk.Controls.Add(labelTotal);

                    yPosition += 24;
                }
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            using (PrintDocument pd = new PrintDocument())
            {
                pd.PrintPage += new PrintPageEventHandler(PrintPage);
                pd.DefaultPageSettings.PaperSize = new PaperSize("Custom", 733, 820);
                pd.DefaultPageSettings.PrinterResolution = new PrinterResolution
                {
                    Kind = PrinterResolutionKind.High,
                };
                pd.Print();
            }
            this.Close();
        }

        private void PrintPage(object o, PrintPageEventArgs e)
        {
            CaptureScreen();
            e.Graphics.DrawImage(memoryImage, new Rectangle(0, 0, 733, 820), new Rectangle(0, 0, memoryImage.Width, memoryImage.Height), GraphicsUnit.Pixel);
        }

        private void CaptureScreen()
        {
            int width = panelStruk.Width;
            int height = panelStruk.Height;

            memoryImage = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            memoryImage.SetResolution(1000, 1000); 
            panelStruk.DrawToBitmap(memoryImage, new Rectangle(0, 0, width, height));
        }

        private void Struk_Load(object sender, EventArgs e)
        {
        }
    }
}
