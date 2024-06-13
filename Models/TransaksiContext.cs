using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COFFE_SHARP.View;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COFFE_SHARP.Models
{
    public class TransaksiContext
    {
        private readonly string connStr;
        public Rekap rekapPenjualan;
        public event EventHandler NewTransaksi;

        public TransaksiContext()
        {
            connStr = "Host=localhost;Port=5432;Username=postgres;Password=dianeka@05;Database=CoffeSharp;";
            rekapPenjualan = new Rekap();
        }

        protected virtual void OnNewTransaksi(EventArgs e)
        {
            NewTransaksi?.Invoke(this, e);
        }

        public int GenerateTransaksiID()
        {
            int newID;
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT MAX(id_transaksi) FROM transaksi"; 
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result == DBNull.Value)
                        newID = 1;
                    else
                        newID = Convert.ToInt32(result) + 1;
                }
            }
            return newID;
        }

        public List<int> GenerateDetailTransaksiIDs(int count)
        {
            List<int> ids = new List<int>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT COALESCE(MAX(id_detail_transaksi), 0) + 1 FROM detail_transaksi";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    int maxID = Convert.ToInt32(cmd.ExecuteScalar());
                    for (int i = 0; i < count; i++)
                    {
                        ids.Add(maxID + i);
                    }
                }
            }
            return ids;
        }

        public int GenerateIDPembayaran()
        {
            int IDTransaksi;
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT MAX(id_pembayaran) FROM pembayaran";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result == DBNull.Value)
                        IDTransaksi = 1;
                    else
                        IDTransaksi = Convert.ToInt32(result) + 1;
                }
            }
            return IDTransaksi;
        }

        public void SimpanTransaksi(Transaksi transaksi, DataPembayaran pembayaran)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        pembayaran.IdPembayaran = GenerateIDPembayaran();

                        string queryInsertPembayaran = "INSERT INTO pembayaran(id_pembayaran, jumlah_pembayaran, id_metode) VALUES (@idPembayaran, @jumlahPembayaran, @idMetode)";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(queryInsertPembayaran, conn))
                        {
                            cmd.Parameters.AddWithValue("idPembayaran", pembayaran.IdPembayaran);
                            cmd.Parameters.AddWithValue("jumlahPembayaran", pembayaran.JumlahPembayaran);
                            cmd.Parameters.AddWithValue("idMetode", pembayaran.IdMetode);
                            cmd.ExecuteNonQuery();
                        }

                        transaksi.IdTransaksi = GenerateTransaksiID();
                        transaksi.IdAdmin = SessionInfo.idAdmin;

                        string queryInsertTransaksi = "INSERT INTO transaksi (id_transaksi, tanggal_transaksi, id_admin, total_harga, id_pembayaran) VALUES (@idTransaksi, @tanggalTransaksi, @idAdmin, @totalHarga, @idPembayaran)";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(queryInsertTransaksi, conn))
                        {
                            cmd.Parameters.AddWithValue("idTransaksi", transaksi.IdTransaksi);
                            cmd.Parameters.AddWithValue("tanggalTransaksi", transaksi.TanggalTransaksi);
                            cmd.Parameters.AddWithValue("idAdmin", transaksi.IdAdmin);
                            cmd.Parameters.AddWithValue("totalHarga", transaksi.TotalHarga);
                            cmd.Parameters.AddWithValue("idPembayaran", pembayaran.IdPembayaran);
                            cmd.ExecuteNonQuery();
                        }

                        List<int> detailIDs = GenerateDetailTransaksiIDs(transaksi.DetailTransaksiList.Count);

                        string queryInsertDetail = "INSERT INTO detail_transaksi (id_detail_transaksi, id_transaksi, id_produk, jumlah_produk, harga) VALUES (@idDetailTransaksi, @idTransaksi, @idProduk, @jumlahProduk, @harga)";
                        for (int i = 0; i < transaksi.DetailTransaksiList.Count; i++)
                        {
                            var detail = transaksi.DetailTransaksiList[i];
                            detail.IdDetailTransaksi = detailIDs[i];
                            using (NpgsqlCommand cmd = new NpgsqlCommand(queryInsertDetail, conn))
                            {
                                cmd.Parameters.AddWithValue("idDetailTransaksi", detail.IdDetailTransaksi);
                                cmd.Parameters.AddWithValue("idTransaksi", transaksi.IdTransaksi);
                                cmd.Parameters.AddWithValue("idProduk", detail.IdProduk);
                                cmd.Parameters.AddWithValue("jumlahProduk", detail.JumlahProduk);
                                cmd.Parameters.AddWithValue("harga", detail.HargaProduk);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error while saving transaction: " + ex.Message);
                    }
                }
            }
        }

        public Transaksi GetLatestTransaksi()
        {
            Transaksi transaksi = null;

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();

                string queryTransaksi = @"
                    SELECT t.id_transaksi, t.tanggal_transaksi, t.id_admin, t.total_harga, t.id_pembayaran, a.nama
                    FROM transaksi t
                    JOIN admin a ON t.id_admin = a.id_admin
                    ORDER BY t.id_transaksi DESC LIMIT 1";
                using (NpgsqlCommand cmd = new NpgsqlCommand(queryTransaksi, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            transaksi = new Transaksi
                            {
                                IdTransaksi = reader.GetInt32(0),
                                TanggalTransaksi = reader.GetDateTime(1),
                                IdAdmin = reader.GetInt32(2),
                                TotalHarga = reader.GetInt32(3),
                                IdPembayaran = reader.GetInt32(4),
                                NamaAdmin = reader.GetString(5),
                                DetailTransaksiList = new List<DetailTransaksi>()
                            };
                        }
                    }
                }

                if (transaksi != null)
                {
                    string queryDetail = "SELECT id_produk, jumlah_produk, harga FROM detail_transaksi WHERE id_transaksi = @idTransaksi";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(queryDetail, conn))
                    {
                        cmd.Parameters.AddWithValue("idTransaksi", transaksi.IdTransaksi);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                transaksi.DetailTransaksiList.Add(new DetailTransaksi
                                {
                                    IdProduk = reader.GetInt32(0),
                                    JumlahProduk = reader.GetInt32(1),
                                    HargaProduk = reader.GetInt32(2)
                                });
                            }
                        }
                    }
                }
            }

            return transaksi;
        }

        public Produk GetProdukById(int idProduk)
        {
            Produk produk = null;

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT nama_produk, harga FROM produk WHERE id_produk = @idProduk";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idProduk", idProduk);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            produk = new Produk
                            {
                                Nama = reader.GetString(0),
                                Harga = reader.GetDecimal(1)
                            };
                        }
                    }
                }
            }

            return produk;
        }

        public long TotalProdukTerjual()
        {
            string query_count = @"
            SELECT SUM(dt.jumlah_produk)
            FROM detail_transaksi dt
            JOIN transaksi t ON t.id_transaksi = dt.id_transaksi
            WHERE t.id_admin = @IdAdmin";
            long totalProdukTerjual = 0;
            int idAdmin = SessionInfo.idAdmin;
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query_count, conn))
                {
                    cmd.Parameters.AddWithValue("@IdAdmin", idAdmin);
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalProdukTerjual = Convert.ToInt64(result);
                    }
                }
            }
            return totalProdukTerjual;
        }

        public decimal TotalPendapatan()
        {
            string query_sum = @"
            SELECT SUM(total_harga)
            FROM transaksi
            WHERE id_admin = @IdAdmin";
            decimal totalPendapatan = 0;
            int idAdmin = SessionInfo.idAdmin;
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query_sum, conn))
                {
                    cmd.Parameters.AddWithValue("@IdAdmin", idAdmin);
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalPendapatan = Convert.ToDecimal(result);
                    }
                }
            }
            return totalPendapatan;
        }


        public List<Transaksi> GetRiwayatTransaksi()
        {
            List<Transaksi> riwayatTransaksi = new List<Transaksi>();
            int idAdmin = SessionInfo.idAdmin;
            string query = @"
            SELECT t.id_transaksi, t.tanggal_transaksi, p.nama_produk, dt.jumlah_produk, dt.harga, SUM(dt.jumlah_produk * dt.harga) as total_harga
            FROM transaksi t
            JOIN detail_transaksi dt ON t.id_transaksi = dt.id_transaksi
            JOIN produk p ON p.id_produk = dt.id_produk
            WHERE t.id_admin = @IdAdmin
            GROUP BY t.id_transaksi, t.tanggal_transaksi, p.nama_produk, dt.jumlah_produk, dt.harga
            ORDER BY t.id_transaksi DESC";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdAdmin", idAdmin);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idTransaksi = reader.GetInt32(0);
                            DateTime tanggalTransaksi = reader.GetDateTime(1);
                            string namaProduk = reader.GetString(2);
                            int jumlahProduk = reader.GetInt32(3);
                            decimal hargaProduk = reader.GetDecimal(4);
                            decimal totalHarga = reader.GetDecimal(5);

                            Transaksi currentTransaksi = riwayatTransaksi.Find(t => t.IdTransaksi == idTransaksi);
                            if (currentTransaksi == null)
                            {
                                currentTransaksi = new Transaksi
                                {
                                    IdTransaksi = idTransaksi,
                                    TanggalTransaksi = tanggalTransaksi,
                                    TotalHarga = totalHarga,
                                    DetailTransaksiList = new List<DetailTransaksi>()
                                };
                                riwayatTransaksi.Add(currentTransaksi);
                            }

                            DetailTransaksi detailTransaksi = new DetailTransaksi
                            {
                                NamaProduk = namaProduk,
                                JumlahProduk = jumlahProduk,
                                HargaProduk = hargaProduk
                            };
                            currentTransaksi.DetailTransaksiList.Add(detailTransaksi);
                        }
                    }
                }
            }
            return riwayatTransaksi;
        }


        public double GetTotalPembayaranHariIni(int idAdmin)
        {
            string query = @"
            SELECT COALESCE(SUM(t.total_harga), 0) AS pembayaran_hari_ini
            FROM transaksi t
            WHERE t.tanggal_transaksi >= CAST(CURRENT_DATE AS DATE)
            AND t.tanggal_transaksi < CAST(CURRENT_DATE + INTERVAL '1 DAY' AS DATE)
            AND t.id_admin = @idAdmin";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idAdmin", idAdmin);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        rekapPenjualan.Harian = Convert.ToDouble(result);
                    }
                }
            }
            return rekapPenjualan.Harian;
        }

        public double GetTotalPembayaranMingguIni(int idAdmin)
        {
            string query = @"
            SELECT coalesce(SUM(total_harga),0) as pembayaran_minggu_ini
            FROM transaksi 
            WHERE tanggal_transaksi >= now() - INTERVAL '1 week' AND tanggal_transaksi <= now()
            AND id_admin = @idAdmin";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idAdmin", idAdmin);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        rekapPenjualan.Weekly = Convert.ToDouble(result);
                    }
                }
            }
            return rekapPenjualan.Weekly;
        }

        public double GetTotalPembayaranBulanIni(int idAdmin)
        {
            string query = @"
            SELECT COALESCE(SUM(t.total_harga), 0) AS pembayaran_bulan_ini
            FROM transaksi t
            WHERE EXTRACT(MONTH FROM t.tanggal_transaksi) = EXTRACT(MONTH FROM NOW())
            AND EXTRACT(YEAR FROM t.tanggal_transaksi) = EXTRACT(YEAR FROM NOW())
            AND t.id_admin = @idAdmin";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idAdmin", idAdmin);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        rekapPenjualan.Monthly = Convert.ToDouble(result);
                    }
                }
            }
            return rekapPenjualan.Monthly;
        }

        public double GetTotalPembayaranTanggalDipilih(DateTime tanggalAwal, DateTime tanggalAkhir, int idAdmin)
        {
            string query = @"
            SELECT COALESCE(SUM(t.total_harga), 0) AS pembayaran_dipilih
            FROM transaksi t
            WHERE t.tanggal_transaksi BETWEEN @tanggal_awal AND @tanggal_akhir
            AND t.id_admin = @idAdmin";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tanggal_awal", tanggalAwal);
                    cmd.Parameters.AddWithValue("@tanggal_akhir", tanggalAkhir);
                    cmd.Parameters.AddWithValue("@idAdmin", idAdmin);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        rekapPenjualan.Dipilih = Convert.ToDouble(result);
                    }
                }
            }
            return rekapPenjualan.Dipilih;
        }
    }
}
