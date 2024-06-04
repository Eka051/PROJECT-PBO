using COFFE_SHARP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFE_SHARP.View
{
    public partial class Tunai : UserControl
    {
        public TextBox TextBoxNominal => textBoxNominal;
        Pembayaran pembayaran;
        Transaksi transaksi;
        TransaksiContext transaksiContext;
        UCTransaksi ucTransaksi;
        private int IDMetode;
        private bool isFormatting = false;

        public Tunai(int IDMetode, UCTransaksi ucTransaksi)
        {
            InitializeComponent();
            this.ucTransaksi = ucTransaksi;
            this.IDMetode = IDMetode;
            labelTotalHarga.Text = ucTransaksi.GetTotalHarga().ToString("N0");
            UpdateKembalian();
        }

        private void buttonLanjutkan_Click(object sender, EventArgs e)
        {
            decimal jumlahPembayaran;

            if (!decimal.TryParse(TextBoxNominal.Text, out jumlahPembayaran))
            {
                MessageBox.Show("Masukkan Nominal yang valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int totalHarga = ucTransaksi.GetTotalHarga();
            if (jumlahPembayaran < totalHarga)
            {
                MessageBox.Show("Nominal kurang dari total harga!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Pembayaran Berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ucTransaksi.SimpanTransaksi(IDMetode, jumlahPembayaran);
            this.Hide();
            Struk struk = new Struk();
            struk.Show();
        }

        private void UpdateKembalian()
        {
            decimal jumlahPembayaran;
            if (decimal.TryParse(textBoxNominal.Text, out jumlahPembayaran))
            {
                int totalHarga = ucTransaksi.GetTotalHarga();
                decimal kembalian = jumlahPembayaran - totalHarga;
                labelKembalian.Text = "Rp. " + kembalian.ToString("N0");
            }
            else
            {
                labelKembalian.Text = "Rp. 0";
            }
        }

        private void textBoxNominal_TextChanged(object sender, EventArgs e)
        {
            if (!isFormatting)
            {
                isFormatting = true;
                int selectionStart = textBoxNominal.SelectionStart;
                int selectionLength = textBoxNominal.SelectionLength;

                string text = textBoxNominal.Text.Replace(".", "").Replace(",", "");
                if (decimal.TryParse(text, out decimal result))
                {
                    textBoxNominal.Text = result.ToString("N0", CultureInfo.CurrentCulture);
                    textBoxNominal.SelectionStart = selectionStart + (textBoxNominal.Text.Length - text.Length);
                    textBoxNominal.SelectionLength = selectionLength;
                }
                isFormatting = false;
            }
            UpdateKembalian();
        }
    }

}
