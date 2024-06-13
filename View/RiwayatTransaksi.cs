using COFFE_SHARP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace COFFE_SHARP.View
{
    public partial class RiwayatTransaksi : UserControl
    {
        MainForm mainForm;
        TransaksiContext transaksiContext;
        LoginAdminContext adminContext = new LoginAdminContext();

        public RiwayatTransaksi(MainForm mainForm, TransaksiContext transaksiContext, LoginAdminContext loginAdminContext)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.transaksiContext = transaksiContext;
            int idAdmin = SessionInfo.idAdmin;
            loginAdminContext.AdminLoggedIn += OnAdminLoggedIn;
            transaksiContext.NewTransaksi += OnNewTransaksi;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            dataGridView1.Font = new System.Drawing.Font("SF Pro Display", 12); 
        }

        private void OnAdminLoggedIn(object sender, int adminId)
        {
            SessionInfo.idAdmin = adminId;
            LoadRiwayat();
        }

        private void OnNewTransaksi(object sender, EventArgs e)
        {
            LoadRiwayat();
        }

        private void RiwayatTransaksi_Load(object sender, EventArgs e)
        {
            LoadRiwayat();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            mainForm.ShowTransaksi();
        }


        private void LoadRiwayat(string filter = "")
        {
            List<Transaksi> riwayat_ts = transaksiContext.GetRiwayatTransaksi();

            var displayData = riwayat_ts.SelectMany(t => t.DetailTransaksiList.Select(dt => new
            {
                t.IdTransaksi,
                t.TanggalTransaksi,
                dt.NamaProduk,
                dt.JumlahProduk,
                dt.HargaProduk,
                t.TotalHarga
            })).ToList();

            if (!string.IsNullOrEmpty(filter))
            {
                displayData = displayData.Where(p => p.NamaProduk.ToLower().Contains(filter.ToLower())).ToList();
            }

            dataGridView1.DataSource = displayData;

            if (dataGridView1.Columns["IdTransaksi"] != null)
            {
                dataGridView1.Columns["IdTransaksi"].HeaderText = "ID Transaksi";
                dataGridView1.Columns["TanggalTransaksi"].HeaderText = "Tanggal Transaksi";
                dataGridView1.Columns["NamaProduk"].HeaderText = "Nama Produk";
                dataGridView1.Columns["JumlahProduk"].HeaderText = "Jumlah Produk";
                dataGridView1.Columns["HargaProduk"].HeaderText = "Harga Produk";
                dataGridView1.Columns["TotalHarga"].HeaderText = "Harga Total";
            }

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Resizable = DataGridViewTriState.True;
            }
        }
    }
}
