using COFFE_SHARP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFE_SHARP
{
    public partial class UCTransaksi : UserControl
    {
        MainForm mainForm;
        IProdukContext produkContext;
        private List<Panel> cartItems = new List<Panel>();
        private Dictionary<int, int> productQuantities = new Dictionary<int, int>();

        public UCTransaksi(MainForm mainForm, IProdukContext produkContext)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.produkContext = produkContext ?? throw new ArgumentNullException(nameof(produkContext));
            LoadProducts();
            produkContext.ProdukDiubah += ProdukContext_ProdukDiubah;
        }

        private void ProdukContext_ProdukDiubah(object? sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                mainForm.ShowLogin();
            }
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

        private Panel CreateProductPanel(Produk produk)
        {
            Panel dspProduk = new Panel
            {
                Size = new Size(190, 286),
                BackgroundImage = Properties.Resources.dspProduk,
                BackgroundImageLayout = ImageLayout.Zoom,
                BorderStyle = BorderStyle.None,
                Margin = new Padding(8),
                Tag = produk
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
                Location = new Point(10, 169),
                Size = new Size(180, 23),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblHargaProduk = new Label
            {
                Text = "Rp. " + produk.Harga.ToString("N0"),
                Font = new Font("SF Pro Display", 14, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.DarkOrange,
                Location = new Point(41, 192),
                Size = new Size(120, 23),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Button BtnAdd = new Button
            {
                BackgroundImage = Properties.Resources.addTransaction,
                BackgroundImageLayout = ImageLayout.Center,
                Location = new Point(73, 227),
                Size = new Size(40, 40),
            };
            BtnAdd.Click += BtnAdd_Click;

            dspProduk.Controls.Add(PBProduk);
            dspProduk.Controls.Add(lblNamaProduk);
            dspProduk.Controls.Add(lblHargaProduk);
            dspProduk.Controls.Add(BtnAdd);

            return dspProduk;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Button btnAdd = (Button)sender;
            Panel panel = (Panel)btnAdd.Parent;

            Produk produk = (Produk)panel.Tag;

            bool found = false;
            foreach (Panel cartItem in cartItems)
            {
                Produk cartProduk = (Produk)cartItem.Tag;
                if (cartProduk.Id == produk.Id)
                {
                    found = true;
                    UpdateCartItemQuantity(cartItem, 1);
                    break;
                }
            }

            if (!found)
            {
                Panel cartPanel = DaftarTransaksi(produk, 1);
                cartItems.Add(cartPanel);
                flowLayoutCart.Controls.Add(cartPanel);
                productQuantities[produk.Id] = 1;
            }
            TotalHargaTransaksi();
        }

        private void UpdateCartItemQuantity(Panel cartItem, int increment)
        {
            Label lblJumlahProduk = cartItem.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Name == "lblJumlahProduk");

            if (lblJumlahProduk != null)
            {
                int currentQuantity = int.Parse(lblJumlahProduk.Text);
                int newQuantity = currentQuantity + increment;
                lblJumlahProduk.Text = newQuantity.ToString();

                if (cartItem.Tag is Produk produk)
                {
                    productQuantities[produk.Id] = newQuantity;
                }
            }

            TotalHargaTransaksi();
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

        private Panel DaftarTransaksi(Produk produk, int jumlah)
        {
            Panel panel = new Panel
            {
                Size = new Size(380, 106),
                BackColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.None,
                Margin = new Padding(10),
                Tag = produk
            };

            PictureBox PBProduk = new PictureBox
            {
                Size = new Size(83, 83),
                BackColor = Color.Transparent,
                Location = new Point(15, 10),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            if (produk.gambarProduk != null)
            {
                PBProduk.Image = Image.FromStream(new MemoryStream(produk.gambarProduk));
            }

            Label lblNamaProduk = new Label
            {
                Text = produk.Nama,
                Font = new Font("SF Pro Display", 14, FontStyle.Bold),
                BackColor = Color.Transparent,
                Location = new Point(102, 20),
                Size = new Size(180, 23),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label lblHargaProduk = new Label
            {
                Text = "Rp. " + produk.Harga.ToString("N0"),
                Font = new Font("SF Pro Display", 14, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.DarkOrange,
                Location = new Point(102, 51),
                Size = new Size(120, 23),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label lblJumlahProduk = new Label
            {
                Name = "lblJumlahProduk",
                Text = jumlah.ToString(),
                Font = new Font("SF Pro Display", 18, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.DarkOrange,
                Location = new Point(270, 65),
                Size = new Size(45, 40),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Button btnSubs = new Button
            {
                BackgroundImage = Properties.Resources.minusIcon,
                BackgroundImageLayout = ImageLayout.Center,
                Location = new Point(227, 68),
                Size = new Size(32, 32),
            };
            btnSubs.Click += (sender, e) => subsTotal_Click(sender, e, lblJumlahProduk, produk.Id);

            Button btnAdd = new Button
            {
                BackgroundImage = Properties.Resources.plusIcon,
                BackgroundImageLayout = ImageLayout.Center,
                Location = new Point(324, 68),
                Size = new Size(32, 32),
            };
            btnAdd.Click += (sender, e) => addTotal_Click(sender, e, lblJumlahProduk, produk.Id);

            Button btnRemove = new Button
            {
                BackgroundImage = Properties.Resources.DeleteButton,
                BackgroundImageLayout = ImageLayout.Center,
                Location = new Point(320, 10),
                Size = new Size(33, 36),
            };
            btnRemove.Click += (sender, e) => RemoveCartItem(panel, produk.Id);

            panel.Controls.Add(PBProduk);
            panel.Controls.Add(lblNamaProduk);
            panel.Controls.Add(lblHargaProduk);
            panel.Controls.Add(lblJumlahProduk);
            panel.Controls.Add(btnSubs);
            panel.Controls.Add(btnAdd);
            panel.Controls.Add(btnRemove);

            return panel;
        }

        private void subsTotal_Click(object sender, EventArgs e, Label lblJumlahProduk, int produkId)
        {
            int jumlah = int.Parse(lblJumlahProduk.Text);
            if (jumlah > 1)
            {
                jumlah--;
                lblJumlahProduk.Text = jumlah.ToString();
                productQuantities[produkId] = jumlah;
            }
            else
            {
                RemoveCartItem((Panel)lblJumlahProduk.Parent, produkId);
            }
            TotalHargaTransaksi();
        }

        private void addTotal_Click(object sender, EventArgs e, Label lblJumlahProduk, int produkId)
        {
            int jumlah = int.Parse(lblJumlahProduk.Text);
            jumlah++;
            lblJumlahProduk.Text = jumlah.ToString();
            productQuantities[produkId] = jumlah;
            TotalHargaTransaksi();
        }

        private void RemoveCartItem(Panel panel, int produkId)
        {
            flowLayoutCart.Controls.Remove(panel);
            cartItems.Remove(panel);
            productQuantities.Remove(produkId);
            TotalHargaTransaksi();
        }

        private void TotalHargaTransaksi()
        {
            int totalHarga = 0;
            foreach (Panel cartItem in cartItems)
            {
                if (cartItem.Tag is Produk produk)
                {
                    if (productQuantities.TryGetValue(produk.Id, out int jumlah))
                    {
                        totalHarga += (int)produk.Harga * jumlah;
                    }
                }
            }
            totalHargaTrs.Text = "Rp. " + totalHarga.ToString("N0");
        }

        private void btnLanjutTransaksi_Click(object sender, EventArgs e)
        {

        }
    }
}
