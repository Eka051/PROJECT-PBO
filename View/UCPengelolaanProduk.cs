using COFFE_SHARP.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace COFFE_SHARP
{
    public partial class UCPengelolaanProduk : UserControl
    {
        private MainForm mainForm;
        private readonly IProdukContext produkContext;

        public UCPengelolaanProduk(MainForm mainForm, IProdukContext produkContext)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.produkContext = produkContext;
            produkContext.ProdukDiubah += ProdukContext_ProdukDiubah;
            LoadProducts();
        }

        private void ProdukContext_ProdukDiubah(object? sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            mainForm.ShowDashboard();
        }

        private void btnPengelolaanStok_Click(object sender, EventArgs e)
        {
            mainForm.ShowKelolaStok();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                mainForm.ShowLogin();
            }
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            mainForm.ShowTransaksi();
        }

        private void btnTambahProduk_Click(object sender, EventArgs e)
        {
            TambahProduk tambahProduk = new TambahProduk(produkContext);
            tambahProduk.Show();
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
                Location = new Point(10, 167),
                Size = new Size(180, 23),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblHargaProduk = new Label
            {
                Text = "Rp. " + produk.Harga.ToString("N0"),
                Font = new Font("SF Pro Display", 14, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.DarkOrange,
                Location = new Point(40, 191),
                Size = new Size(120, 23),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Button btnEdit = new Button
            {
                Text = "       Edit",
                Font = new Font("SF Pro Display", 12, FontStyle.Bold),
                Image = Properties.Resources.editIcon,
                ImageAlign = ContentAlignment.BottomLeft,
                Location = new Point(32, 223),
                Size = new Size(89, 36)
            };
            btnEdit.Click += (sender, e) => EditProduct(produk);

            Button btnHapus = new Button
            {
                BackgroundImage = Properties.Resources.DeleteButton,
                BackgroundImageLayout = ImageLayout.Center,
                Location = new Point(127, 223),
                Size = new Size(33, 36)
            };
            btnHapus.Click += (sender, e) => HapusProduct(produk);

            dspProduk.Controls.Add(PBProduk);
            dspProduk.Controls.Add(lblNamaProduk);
            dspProduk.Controls.Add(lblHargaProduk);
            dspProduk.Controls.Add(btnEdit);
            dspProduk.Controls.Add(btnHapus);

            return dspProduk;
        }

        public void LoadProducts()
        {
            flowLayoutPanelProduk.Controls.Clear();

            List<Produk> products = produkContext.GetProdukFromDatabase();

            foreach (Produk product in products)
            {
                Panel panel = CreateProductPanel(product);
                flowLayoutPanelProduk.Controls.Add(panel);
            }
        }

        private void EditProduct(Produk produk)
        {
            EditProduk editProduk = new EditProduk(produkContext, produk);
            editProduk.Show();
        }

        private void HapusProduct(Produk produk)
        {
            DialogResult result = MessageBox.Show($"Apakah Anda yakin ingin menghapus produk '{produk.Nama}'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    produkContext.HapusProduk(produk.Id);
                    MessageBox.Show("Produk berhasil dihapus");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat menghapus produk: " + ex.Message);
                }
            }
        }
    }
}