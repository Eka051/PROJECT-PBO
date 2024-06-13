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
    public partial class RekapPenjualan : UserControl
    {
        MainForm mainForm;
        TransaksiContext context = new TransaksiContext();
        Rekap rekap = new Rekap();
        public RekapPenjualan(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            mainForm.ShowDashboard();
        }

        private void RekapPenjualan_Load(object sender, EventArgs e)
        {

        }

        private void custom_CheckedChanged(object sender, EventArgs e)
        {
            DateTime tanggalAwal = dateTimePicker1.Value;
            DateTime tanggalAkhir = dateTimePicker2.Value;
            int idAdmin = SessionInfo.idAdmin;

            if (custom.Checked)
            {
                if (tanggalAwal > tanggalAkhir)
                {
                    MessageBox.Show("Tanggal awal tidak boleh lebih besar dari tanggal akhir", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double totalPembayaran = context.GetTotalPembayaranTanggalDipilih(tanggalAwal, tanggalAkhir, idAdmin);
                    rekap.Dipilih = totalPembayaran;
                    if (rekap.Dipilih == 0)
                    {
                        MessageBox.Show("Tidak ada data penjualan pada tanggal tersebut", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        labelPeriode.Text = "Rp. " + rekap.Dipilih.ToString("N0");
                    }
                }
            }
            else
            {
                labelPeriode.Text = "Rp. 0";
            }
        }


        private void hariIni_CheckedChanged(object sender, EventArgs e)
        {
            int idAdmin = SessionInfo.idAdmin;

            if (hariIni.Checked)
            {
                double totalPembayaran = context.GetTotalPembayaranHariIni(idAdmin);
                rekap.Harian = totalPembayaran;
                if (rekap.Harian == 0)
                {
                    MessageBox.Show("Tidak ada data penjualan hari ini", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    labelHariIni.Text = "Rp. " + rekap.Harian.ToString("N0");
                }
            }
            else
            {
                labelHariIni.Text = "Rp. 0";
            }
        }


        private void MingguIni_CheckedChanged(object sender, EventArgs e)
        {
            int idAdmin = SessionInfo.idAdmin;

            if (MingguIni.Checked)
            {
                double totalPembayaran = context.GetTotalPembayaranMingguIni(idAdmin);
                rekap.Weekly = totalPembayaran;
                if (rekap.Weekly == 0)
                {
                    MessageBox.Show("Tidak ada data penjualan minggu ini", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    labelMingguIni.Text = "Rp. " + rekap.Weekly.ToString("N0");
                }
            }
            else
            {
                labelMingguIni.Text = "Rp. 0";
            }
        }


        private void BulanIni_CheckedChanged(object sender, EventArgs e)
        {
            int idAdmin = SessionInfo.idAdmin;

            if (BulanIni.Checked)
            {
                double totalPembayaran = context.GetTotalPembayaranBulanIni(idAdmin);
                rekap.Monthly = totalPembayaran;
                if (rekap.Monthly == 0)
                {
                    MessageBox.Show("Tidak ada data penjualan bulan ini", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    labelBulanIni.Text = "Rp. " + rekap.Monthly.ToString("N0");
                }
            }
            else
            {
                labelBulanIni.Text = "Rp. 0";
            }
        }

    }
}
