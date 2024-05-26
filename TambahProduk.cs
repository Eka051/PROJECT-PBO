using COFFE_SHARP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFE_SHARP
{
    public partial class TambahProduk : Form
    {
        private OpenFileDialog openFileDialog;
        private IProdukContext produkContext;

        public event EventHandler ProdukDiubah;

        public TambahProduk(IProdukContext produkContext)
        {
            InitializeComponent();
            this.produkContext = produkContext;
            openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Pilih Gambar";
            openFileDialog.Filter = "File Gambar (*.jpg, *.png)|*.jpg;*.png";
        }

        private void BtnUpload_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedFileName = openFileDialog.FileName;
                    gambarProduk.Image = new Bitmap(selectedFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

        private byte[] ImageToBinary(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void TambahProduk_Load(object sender, EventArgs e)
        {

        }

        private void BtnSimpan_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = produkContext.GenerateIdProduk();
                string nama = namaProduk.Text;
                int stok = 0;
                decimal harga = decimal.Parse(hargaProduk.Text);
                DateTime tanggalExp = tglExpProduk.Value;
                byte[] gambar_produk = ImageToBinary(gambarProduk.Image);

                Produk produk = new Produk()
                {
                    Id = id,
                    Nama = nama,
                    Stok = stok,
                    Harga = harga,
                    TanggalExp = tanggalExp,
                    gambarProduk = gambar_produk
                };

                produkContext.TambahProduk(produk);
                MessageBox.Show("Produk berhasil ditambahkan");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan penyimpanan: " + ex.Message);
            }
        }

    }

}
