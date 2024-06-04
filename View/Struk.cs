using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COFFE_SHARP.Models;

namespace COFFE_SHARP.View
{
    public partial class Struk : Form
    {
        private string Date;
        private TransaksiContext transaksiContext;
        private Transaksi transaksiTerbaru;

        public Struk()
        {
            InitializeComponent();
            transaksiContext = new TransaksiContext();
            transaksiTerbaru = transaksiContext.GetLatestTransaksi();

            if (transaksiTerbaru != null)
            {
                Date = transaksiTerbaru.TanggalTransaksi.ToString("d/MM/yyyy");
                labelTanggal.Text = Date;
                labelAdmin.Text = transaksiTerbaru.NamaAdmin;

                DisplayTransaksiDetails();
            }
        }

        private void DisplayTransaksiDetails()
        {
            panelPrint.Controls.Clear(); // Clear any existing controls in the panel

            int yOffset = 10; // Initial offset for the first label
            int labelHeight = 20; // Height of each label
            int xOffsetNamaProduk = 10;
            int xOffsetHarga = 200;
            int xOffsetQty = 300;
            int xOffsetTotalHarga = 400;

            // Add header labels
            Label lblHeaderNamaProduk = new Label
            {
                Text = "Nama Produk",
                Location = new Point(xOffsetNamaProduk, yOffset),
                Font = new Font(Font, FontStyle.Bold),
                AutoSize = true
            };
            panelPrint.Controls.Add(lblHeaderNamaProduk);

            Label lblHeaderHarga = new Label
            {
                Text = "Harga",
                Location = new Point(xOffsetHarga, yOffset),
                Font = new Font(Font, FontStyle.Bold),
                AutoSize = true
            };
            panelPrint.Controls.Add(lblHeaderHarga);

            Label lblHeaderQty = new Label
            {
                Text = "Quantity",
                Location = new Point(xOffsetQty, yOffset),
                Font = new Font(Font, FontStyle.Bold),
                AutoSize = true
            };
            panelPrint.Controls.Add(lblHeaderQty);

            Label lblHeaderTotalHarga = new Label
            {
                Text = "Total",
                Location = new Point(xOffsetTotalHarga, yOffset),
                Font = new Font(Font, FontStyle.Bold),
                AutoSize = true
            };
            panelPrint.Controls.Add(lblHeaderTotalHarga);

            yOffset += labelHeight + 10; 

            decimal grandTotal = 0;

            foreach (var detail in transaksiTerbaru.DetailTransaksiList)
            {
                string namaProduk = transaksiContext.GetProductNameById(detail.IdProduk);
                decimal totalHarga = detail.JumlahProduk * detail.HargaProduk;
                grandTotal += totalHarga;

                Label lblNamaProduk = new Label
                {
                    Text = namaProduk,
                    Location = new Point(xOffsetNamaProduk, yOffset),
                    AutoSize = true
                };
                panelPrint.Controls.Add(lblNamaProduk);

                Label lblHarga = new Label
                {
                    Text = detail.HargaProduk.ToString("N0"),
                    Location = new Point(xOffsetHarga, yOffset),
                    AutoSize = true
                };
                panelPrint.Controls.Add(lblHarga);

                Label lblQty = new Label
                {
                    Text = detail.JumlahProduk.ToString(),
                    Location = new Point(xOffsetQty, yOffset),
                    AutoSize = true
                };
                panelPrint.Controls.Add(lblQty);

                Label lblTotalHarga = new Label
                {
                    Text = totalHarga.ToString("N0"),
                    Location = new Point(xOffsetTotalHarga, yOffset),
                    AutoSize = true
                };
                panelPrint.Controls.Add(lblTotalHarga);

                yOffset += labelHeight + 5;
            }

            Label lblGrandTotal = new Label
            {
                Text = $"Total: Rp. {grandTotal.ToString("N0")}",
                Location = new Point(xOffsetTotalHarga, yOffset + 20),
                Font = new Font(Font, FontStyle.Bold),
                AutoSize = true
            };
            panelPrint.Controls.Add(lblGrandTotal);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Print(panelPrint);
        }

        private void Print(Panel panel)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 2150, 2970); 

            printDocument.PrintPage += (sender, e) =>
            {
                Bitmap bitmap = new Bitmap(panel.Width, panel.Height);
                panel.DrawToBitmap(bitmap, new Rectangle(0, 0, panel.Width, panel.Height));

                float scaleX = (float)e.PageBounds.Width / (float)bitmap.Width;
                float scaleY = (float)e.PageBounds.Height / (float)bitmap.Height;
                float scale = Math.Min(scaleX, scaleY);

                int newWidth = (int)(bitmap.Width * scale);
                int newHeight = (int)(bitmap.Height * scale);

                int posX = (e.PageBounds.Width - newWidth) / 2;
                int posY = (e.PageBounds.Height - newHeight) / 2;

                e.Graphics.DrawImage(bitmap, posX, posY, newWidth, newHeight);
            };

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument
            };

            printPreviewDialog.ShowDialog();
        }

        private void CapturePanel(Panel panel)
        {
            panel.Refresh();
            Application.DoEvents();
            memorying = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(memorying, new Rectangle(0, 0, panel.Width, panel.Height));
        }
        private Bitmap memorying;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
