using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using COFFE_SHARP.Models;
using System.Text;
using System.Reflection;
using System.Net;
using COFFE_SHARP.View;

namespace COFFE_SHARP
{
    public partial class UCTransaksi : UserControl
    {
        MainForm mainForm;
        IProdukContext produkContext;
        private List<Panel> cartItems = new List<Panel>();
        private Dictionary<int, int> jumlahProduk = new Dictionary<int, int>();
        private Dictionary<int, Panel> cartItemsById = new Dictionary<int, Panel>();
        private List<DetailTransaksi> keranjangBelanja = new List<DetailTransaksi>();

        public UCTransaksi(MainForm mainForm, IProdukContext produkContext)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.produkContext = produkContext;
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

            if (cartItemsById.TryGetValue(produk.Id, out Panel cartItem))
            {
                if (jumlahProduk[produk.Id] + 1 > produk.Stok)
                {
                    jumlahProduk[produk.Id] = produk.Stok;
                    UpdateCartItemQuantity(cartItem, 0); 
                }
                else
                {
                    UpdateCartItemQuantity(cartItem, 1);
                }
            }
            else
            {
                Panel cartPanel = DaftarTransaksi(produk, 1);
                cartItems.Add(cartPanel);
                cartItemsById[produk.Id] = cartPanel;
                flowLayoutCart.Controls.Add(cartPanel);
                jumlahProduk[produk.Id] = 1;

                keranjangBelanja.Add(new DetailTransaksi
                {
                    IdProduk = produk.Id,
                    HargaProduk = produk.Harga,
                    JumlahProduk = 1
                });
            }
            TotalHargaTransaksi();
        }

        private void UpdateCartItemQuantity(Panel cartItem, int increment)
        {
            TextBox txtJumlahProduk = cartItem.Controls.OfType<TextBox>().FirstOrDefault(lbl => lbl.Name == "txtJumlahProduk");

            if (txtJumlahProduk != null)
            {
                int currentQuantity = int.Parse(txtJumlahProduk.Text);
                int newQuantity = currentQuantity + increment;
                txtJumlahProduk.Text = newQuantity.ToString();

                if (cartItem.Tag is Produk produk)
                {
                    jumlahProduk[produk.Id] = newQuantity;

                    var detailTransaksi = keranjangBelanja.FirstOrDefault(dt => dt.IdProduk == produk.Id);
                    if (detailTransaksi != null)
                    {
                        detailTransaksi.JumlahProduk = newQuantity;
                    }
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
                if (product.Stok > 0)
                {
                    Panel panel = CreateProductPanel(product);
                    flowLayoutPanelProduk.Controls.Add(panel);
                }
            }
        }

        private Panel DaftarTransaksi(Produk produk, int jumlah)
        {
            Panel panel = new Panel
            {
                Size = new Size(384, 114),
                BackgroundImage = Properties.Resources.bgListProduk,
                BackgroundImageLayout = ImageLayout.Center,
                BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
                Margin = new Padding(8),
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

            TextBox txtJumlahProduk = new TextBox
            {
                Name = "txtJumlahProduk",
                Text = jumlah.ToString(),
                Font = new Font("SF Pro Display", 18, FontStyle.Bold),
                BackColor = Color.White,
                BorderStyle = BorderStyle.None,
                ForeColor = Color.Black,
                Location = new Point(255, 68),
                Size = new Size(65, 40),
                TextAlign = HorizontalAlignment.Center
            };

            txtJumlahProduk.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (int.TryParse(txtJumlahProduk.Text, out int newQuantity))
                    {
                        int produkId = produk.Id;
                        var detailTransaksi = keranjangBelanja.FirstOrDefault(dt => dt.IdProduk == produkId);
                        if (detailTransaksi == null && newQuantity <= produk.Stok)
                        {
                            jumlahProduk[produkId] = newQuantity;
                            keranjangBelanja.Add(new DetailTransaksi
                            {
                                IdProduk = produkId,
                                JumlahProduk = newQuantity,
                                HargaProduk = produk.Harga
                            });
                            TotalHargaTransaksi();
                        }
                        else if (detailTransaksi != null)
                        {
                            if (newQuantity <= produk.Stok)
                            {
                                jumlahProduk[produkId] = newQuantity;
                                detailTransaksi.JumlahProduk = newQuantity;
                                TotalHargaTransaksi();
                            }
                            else
                            {
                                jumlahProduk[produkId] = produk.Stok;
                                txtJumlahProduk.Text = produk.Stok.ToString();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Input harus berupa angka!", "EROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            };

            Button btnSubs = new Button
            {
                BackgroundImage = Properties.Resources.minusIcon,
                BackgroundImageLayout = ImageLayout.Center,
                Location = new Point(220, 68),
                Size = new Size(32, 32),
            };
            btnSubs.Click += (sender, e) => subsTotal_Click(sender, e, txtJumlahProduk, produk.Id);

            Button btnAdd = new Button
            {
                BackgroundImage = Properties.Resources.plusIcon,
                BackgroundImageLayout = ImageLayout.Center,
                Location = new Point(324, 68),
                Size = new Size(32, 32),
            };
            btnAdd.Click += (sender, e) => addTotal_Click(sender, e, txtJumlahProduk, produk.Id);

            Button btnRemove = new Button
            {
                BackgroundImage = Properties.Resources.DeleteButton,
                BackgroundImageLayout = ImageLayout.Center,
                Location = new Point(324, 10),
                Size = new Size(33, 36),
            };
            btnRemove.Click += (sender, e) => RemoveCartItem(panel, produk.Id);

            panel.Controls.Add(PBProduk);
            panel.Controls.Add(lblNamaProduk);
            panel.Controls.Add(lblHargaProduk);
            panel.Controls.Add(txtJumlahProduk);
            panel.Controls.Add(btnSubs);
            panel.Controls.Add(btnAdd);
            panel.Controls.Add(btnRemove);

            return panel;
        }

        private void subsTotal_Click(object sender, EventArgs e, TextBox txtJumlahProduk, int produkId)
        {
            int jumlah = int.Parse(txtJumlahProduk.Text);
            if (jumlah > 1)
            {
                jumlah--;
                txtJumlahProduk.Text = jumlah.ToString();
                jumlahProduk[produkId] = jumlah;
                var detailTransaksi = keranjangBelanja.FirstOrDefault(dt => dt.IdProduk == produkId);
                if (detailTransaksi != null)
                {
                    detailTransaksi.JumlahProduk = jumlah;
                }
            }
            else
            {
                RemoveCartItem((Panel)txtJumlahProduk.Parent, produkId);
            }
            TotalHargaTransaksi();
        }

        private void addTotal_Click(object sender, EventArgs e, TextBox txtJumlahProduk, int produkId)
        {
            int jumlah = int.Parse(txtJumlahProduk.Text);
            Produk produk = produkContext.GetProdukFromDatabase().FirstOrDefault(p => p.Id == produkId);
            if (produk != null)
            {
                if (jumlah + 1 > produk.Stok)
                {
                    jumlah = produk.Stok;
                }
                else
                {
                    jumlah++;
                }
            }
            txtJumlahProduk.Text = jumlah.ToString();
            jumlahProduk[produkId] = jumlah;
            var detailTransaksi = keranjangBelanja.FirstOrDefault(dt => dt.IdProduk == produkId);
            if (detailTransaksi != null)
            {
                detailTransaksi.JumlahProduk = jumlah;
            }
            TotalHargaTransaksi();
        }

        private void RemoveCartItem(Panel panel, int produkId)
        {
            flowLayoutCart.Controls.Remove(panel);
            cartItems.Remove(panel);
            cartItemsById.Remove(produkId);
            jumlahProduk.Remove(produkId);
            keranjangBelanja.RemoveAll(dt => dt.IdProduk == produkId);
            TotalHargaTransaksi();
        }

        private void TotalHargaTransaksi()
        {
            int totalHarga = 0;
            foreach (Panel cartItem in cartItems)
            {
                if (cartItem.Tag is Produk produk)
                {
                    if (jumlahProduk.TryGetValue(produk.Id, out int jumlah))
                    {
                        totalHarga += (int)produk.Harga * jumlah;
                    }
                }
            }
            totalHargaTrs.Text = "Rp. " + totalHarga.ToString("N0");
        }

        public int GetTotalHarga()
        {
            int totalHarga = 0;
            foreach (Panel cartItem in cartItems)
            {
                if (cartItem.Tag is Produk produk)
                {
                    if (jumlahProduk.TryGetValue(produk.Id, out int jumlah))
                    {
                        totalHarga += (int)produk.Harga * jumlah;
                    }
                }
            }
            return totalHarga;
        }

        private void btnLanjutTransaksi_Click(object sender, EventArgs e)
        {
            int Id_admin = SessionInfo.idAdmin;
            int IDMetode = 1;
            if (cartItems.Count > 0)
            {
                Pembayaran pembayaran = new Pembayaran(this, new Tunai(IDMetode, this));
                pembayaran.Show();
            }
            else
            {
                MessageBox.Show("Keranjang belanja masih kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SimpanTransaksi(int IDMetode, decimal jumlahPembayaran)
        {
            TransaksiContext transaksiContext = new TransaksiContext();

            Transaksi transaksi = new Transaksi
            {
                TanggalTransaksi = DateTime.Now,
                TotalHarga = GetTotalHarga(),
                IdPembayaran = IDMetode,
                DetailTransaksiList = new List<DetailTransaksi>()
            };

            foreach (Panel cartItem in cartItems)
            {
                if (cartItem.Tag is Produk produk)
                {
                    if (jumlahProduk.TryGetValue(produk.Id, out int jumlah))
                    {
                        DetailTransaksi detailTransaksi = new DetailTransaksi
                        {
                            IdProduk = produk.Id,
                            JumlahProduk = jumlah,
                            HargaProduk = produk.Harga
                        };
                        transaksi.DetailTransaksiList.Add(detailTransaksi);
                    }
                }
            }

            DataPembayaran pembayaran = new DataPembayaran
            {
                JumlahPembayaran = jumlahPembayaran,
                IdMetode = IDMetode
            };

            transaksiContext.SimpanTransaksi(transaksi, pembayaran);

            foreach (DetailTransaksi detail in transaksi.DetailTransaksiList)
            {
                Produk produk = produkContext.GetProdukFromDatabase().FirstOrDefault(p => p.Id == detail.IdProduk);
                if (produk != null)
                {
                    produk.Stok -= detail.JumlahProduk;
                    produkContext.TransaksiProduk(detail.IdProduk, detail.JumlahProduk);
                }
            }

            keranjangBelanja.Clear();
            cartItems.Clear();
            cartItemsById.Clear();
            jumlahProduk.Clear();

            flowLayoutCart.Controls.Clear();
            totalHargaTrs.Text = "Rp. 0";
            LoadProducts();
        }
    }
}
