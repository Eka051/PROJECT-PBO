using COFFE_SHARP.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace COFFE_SHARP
{
    public partial class UserControlDashboard : UserControl
    {
        private MainForm mainForm;
        private readonly IProdukContext produkContext;
        private FlowLayoutPanel flowLayoutPanelproduk;

        public UserControlDashboard(MainForm mainForm, IProdukContext produkContext)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.produkContext = produkContext;
            produkContext.ProdukDiubah += ProdukContext_ProdukDiubah;
            LoadProducts();
            LoadTotalProduk();
            flowLayoutPanelproduk = flowLayoutDashboard;
        }

        private void ProdukContext_ProdukDiubah(object? sender, EventArgs e)
        {
            LoadProducts();
            LoadTotalProduk();
        }

        private void LoadTotalProduk()
        {
            lblTotalProduk.Text = produkContext.TotalProduk().ToString();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            mainForm.ShowDashboard();
        }

        private void btnPengelolaanStok_Click(object sender, EventArgs e)
        {
            mainForm.ShowKelolaStok();
        }

        private void btnPengelolaanProduk_Click(object sender, EventArgs e)
        {
            mainForm.ShowKelolaProduk();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            mainForm.ShowTransaksi();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                mainForm.ShowLogin();
            }
        }


        private Panel CreateProductPanel(Produk produk)
        {
            Panel dspProduk = new Panel
            {
                Size = new Size(190, 286),
                BackgroundImage = Properties.Resources.dspProduk,
                BackgroundImageLayout = ImageLayout.Zoom,
                BorderStyle = BorderStyle.None,
                Margin = new Padding(8)
            };

            PictureBox PBProduk = new PictureBox
            {
                Size = new Size(128, 128),
                BackColor = Color.Transparent,
                Location = new Point(32, 25),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            if (produk.gambarProduk != null)
            {
                PBProduk.Image = Image.FromStream(new MemoryStream(produk.gambarProduk));
            }

            Label lblNamaProduk = new Label
            {
                Text = produk.Nama,
                Font = new Font("SF Pro Display", 13, FontStyle.Bold),
                BackColor = Color.Transparent,
                Location = new Point(10, 180),
                Size = new Size(180, 23),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblHargaProduk = new Label
            {
                Text = "Rp. " + produk.Harga.ToString("N0"),
                Font = new Font("SF Pro Display", 14, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.DarkOrange,
                Location = new Point(40, 208),
                Size = new Size(120, 23),
                TextAlign = ContentAlignment.MiddleCenter
            };

            dspProduk.Controls.Add(PBProduk);
            dspProduk.Controls.Add(lblNamaProduk);
            dspProduk.Controls.Add(lblHargaProduk);

            return dspProduk;
        }

        public void LoadProducts(string filter = "")
        {
            flowLayoutDashboard.Controls.Clear();

            List<Produk> products = produkContext.GetProdukFromDatabase();
            if(!string.IsNullOrEmpty(filter))
            {
                products = products.Where(p => p.Nama.ToLower().Contains(filter.ToLower())).ToList();
            }

            foreach (Produk product in products)
            {
                Panel panel = CreateProductPanel(product);
                flowLayoutDashboard.Controls.Add(panel);
            }
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {

        }

        private void srcBox_TextChanged(object sender, EventArgs e)
        {
            string filter = srcBox.Text;
            LoadProducts(filter);
        }

    }
}
