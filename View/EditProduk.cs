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
    public partial class EditProduk : Form
    {
        private IProdukContext produkContext;
        private OpenFileDialog openFileDialog;
        public Produk Produk { get; private set; }

        public EditProduk(IProdukContext produkContext, Produk produk)
        {
            InitializeComponent();
            this.produkContext = produkContext;
            openFileDialog = new OpenFileDialog();
            Produk = produk;
            namaProduk.Text = produk.Nama;
            kategoriProduk.SelectedItem = produkContext.GetAllNamaKategori().FirstOrDefault(k => produkContext.GetIdKategori(k) == produk.Id_kategori);
            hargaProduk.Text = produk.Harga.ToString();
            gambarProduk.Image = Image.FromStream(new MemoryStream(produk.gambarProduk));
        }

        private void BtnSimpan_Click_1(object sender, EventArgs e)
        {
            Produk.Nama = namaProduk.Text;
            Produk.Harga = decimal.Parse(hargaProduk.Text);
            if (kategoriProduk.SelectedItem != null)
            {
                Produk.Id_kategori = produkContext.GetIdKategori(kategoriProduk.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Kategori produk belum dipilih.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gambarProduk.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    gambarProduk.Image.Save(ms, gambarProduk.Image.RawFormat);
                    Produk.gambarProduk = ms.ToArray();
                }
            }

            DialogResult result = MessageBox.Show("Yakin mengubah produk?", "Konfirmasi Edit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                produkContext.EditProduk(Produk);
                Close();
            }
        }

        private void BtnUpload_Click(object sender, EventArgs e)
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

        private void LoadKategori()
        {
            List<string> kategori = produkContext.GetAllNamaKategori();

            kategoriProduk.DataSource = kategori;

            if (Produk != null)
            {
                List<string> namaKategoriList = produkContext.GetNamaKategori(Produk.Id_kategori);
                string namaKategori = namaKategoriList.FirstOrDefault();

                int index = kategori.IndexOf(namaKategori);

                if (index != -1)
                {
                    kategoriProduk.SelectedIndex = index;
                }
            }
        }

        private void EditProduk_Load(object sender, EventArgs e)
        {
            LoadKategori();
        }
    }
}
