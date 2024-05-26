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
    public partial class EditProduk : Form
    {
        private IProdukContext produkContext;
        public Produk Produk { get; private set; }
        public EditProduk(IProdukContext produkContext, Produk produk)
        {
            InitializeComponent();
            this.produkContext = produkContext;
            Produk = produk;
            namaProduk.Text = produk.Nama;
            hargaProduk.Text = produk.Harga.ToString();
            gambarProduk.Image = Image.FromStream(new System.IO.MemoryStream(produk.gambarProduk));

        }

        private void BtnSimpan_Click_1(object sender, EventArgs e)
        {
            Produk.Nama = namaProduk.Text;
            Produk.Harga = decimal.Parse(hargaProduk.Text);
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
    }
}
