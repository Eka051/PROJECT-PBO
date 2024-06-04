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
        Tunai Tunai;
        public Pembayaran(UCTransaksi UCtransaksi, Tunai tunai)
        {
            InitializeComponent();
            this.UCtransaksi = UCtransaksi;
            Tunai = new Tunai(1, UCtransaksi);
            this.Controls.Add(tunai);
            tunai.Visible = false;
        }

        private void btnQRIS_Click(object sender, EventArgs e)
        {
            int IDMetode = 2;
            QRIS qris = new QRIS(IDMetode, UCtransaksi);
            qris.Show();
            this.Close();
        }

        private void btnTunai_Click(object sender, EventArgs e)
        {
            int IDMetode = 1;
            Tunai tunai = new Tunai(IDMetode, UCtransaksi);
            tunai.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(tunai);
            tunai.Visible = true;
        }

    }
}
