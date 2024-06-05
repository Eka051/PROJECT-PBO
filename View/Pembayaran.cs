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

namespace COFFE_SHARP.View
{
    public partial class Pembayaran : Form
    {
        UCTransaksi UCtransaksi;
        Tunai tunai;
        ProdukContext produkContext;
        public Pembayaran(UCTransaksi UCtransaksi, Tunai tunai)
        {
            InitializeComponent();
            this.UCtransaksi = UCtransaksi;
            this.produkContext = produkContext;
            tunai = new Tunai(1, UCtransaksi);
        }

        private void btnQRIS_Click(object sender, EventArgs e)
        {
            QRIS qris = new QRIS(2, UCtransaksi);
            qris.Show();
            this.Close();
        }

        private void btnTunai_Click(object sender, EventArgs e)
        {
            Tunai tunai = new Tunai(1, UCtransaksi);
            tunai.Show();
            this.Close();
        }

    }
}
