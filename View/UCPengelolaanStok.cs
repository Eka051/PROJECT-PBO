using COFFE_SHARP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFE_SHARP
{
    public partial class UCPengelolaanStok : UserControl
    {

        MainForm mainForm;
        private readonly IProdukContext produkContext;
        public UCPengelolaanStok(MainForm mainForm, IProdukContext produkContext)
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

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            mainForm.ShowDashboard();
        }

        private void btnPengelolaanProduk_Click(object sender, EventArgs e)
        {
            mainForm.ShowKelolaProduk();
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

        private Panel CreateProductPanel(Produk produk)
        {

            Panel dspProduk = new Panel
            {
                Size = new Size(190, 286),
                BackgroundImage = Properties.Resources.dspProduk,
                BackgroundImageLayout = ImageLayout.Zoom,
                BorderStyle = BorderStyle.None,
                Margin = new Padding(8),
                Tag = produk.Id
            };
            if (produk != null)
            {
                dspProduk.Tag = produk.Id;
            }

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

            TextBox txtStok = new TextBox
            {
                Name = "txtStok",
                Text = produk.Stok.ToString(),
                Font = new Font("SF Pro Display", 18, FontStyle.Bold),
                BackColor = Color.White,
                BorderStyle = BorderStyle.None,
                ForeColor = Color.Black,
                Location = new Point(70, 208),
                Size = new Size(60, 40),
                TextAlign = HorizontalAlignment.Center
            };

            txtStok.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (int.TryParse(txtStok.Text, out int stok))
                    {
                        int IdProduk = (int)dspProduk.Tag;
                        produkContext.UpdateStok(IdProduk, stok);
                        e.Handled = true; 
                        e.SuppressKeyPress = true;
                    }
                }
            };

            Button btnSubs = new Button
            {
                BackgroundImage = Properties.Resources.minusIcon,
                BackgroundImageLayout = ImageLayout.Center,
                Location = new Point(28, 208),
                Size = new Size(32, 32),
            };
            btnSubs.Click += (sender, e) =>
            {
                if (int.TryParse(txtStok.Text, out int stok))
                {
                    stok--;
                    txtStok.Text = stok.ToString();

                    int IdProduk = (int)dspProduk.Tag;
                    produkContext.UpdateStok(IdProduk, stok);
                }
            };

            Button btnAdd = new Button
            {
                BackgroundImage = Properties.Resources.plusIcon,
                BackgroundImageLayout = ImageLayout.Center,
                Location = new Point(133, 208),
                Size = new Size(32, 32),
            };
            btnAdd.Click += (sender, e) =>
            {
                if (int.TryParse(txtStok.Text, out int stok))
                {
                    stok++;
                    txtStok.Text = stok.ToString();

                    int IdProduk = (int)dspProduk.Tag;
                    produkContext.UpdateStok(IdProduk, stok);
                }
            };

            dspProduk.Controls.Add(PBProduk);
            dspProduk.Controls.Add(lblNamaProduk);
            dspProduk.Controls.Add(txtStok);
            dspProduk.Controls.Add(btnAdd);
            dspProduk.Controls.Add(btnSubs);

            return dspProduk;
        }

        private void BtnSubs_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
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

        private void UCPengelolaanStok_Load(object sender, EventArgs e)
        {

        }
    }
}
