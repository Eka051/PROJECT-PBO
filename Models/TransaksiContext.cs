using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace COFFE_SHARP.Models
{
    public class TransaksiContext
    {
        private readonly string connStr;

        public TransaksiContext()
        {
            connStr = "Host=localhost;Port=5432;Username=postgres;Password=dianeka@05;Database=CoffeSharp;";
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

        public string GetProductNameById(int idProduk)
        {
            string productName = string.Empty;

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT nama_produk FROM produk WHERE id_produk = @idProduk";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idProduk", idProduk);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        productName = result.ToString();
                    }
                }
            }

            return productName;
        }

    }
}
