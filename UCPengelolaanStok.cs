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
        public UCPengelolaanStok(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }


        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            mainForm.ShowDashboard();
        }

        private void btnPengelolaanProduk_Click(object sender, EventArgs e)
        {
            mainForm.ShowKelolaProduk();
        }
    }
}
