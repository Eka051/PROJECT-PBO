using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void SimpanTransaksi(Transaksi transaksi)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string queryInsertTransaksi = "INSERT INTO transaksi (tanggal_transaksi, id_admin, total_harga, id_pembayaran) VALUES (@tanggalTransaksi, @idAdmin, @totalHarga, @idPembayaran) RETURNING id_transaksi";
                        int idTransaksi;
                        using (NpgsqlCommand cmd = new NpgsqlCommand(queryInsertTransaksi, conn))
                        {
                            cmd.Parameters.AddWithValue("tanggalTransaksi", transaksi.TanggalTransaksi);
                            cmd.Parameters.AddWithValue("idAdmin", transaksi.IdAdmin);
                            cmd.Parameters.AddWithValue("totalHarga", transaksi.TotalHarga);
                            cmd.Parameters.AddWithValue("idPembayaran", transaksi.IdPembayaran);
                            idTransaksi = (int)cmd.ExecuteScalar();
                        }

                        string queryInsertDetail = "INSERT INTO detail_transaksi (id_transaksi, id_produk, jumlah_produk, harga_produk) VALUES (@idTransaksi, @idProduk, @jumlahProduk, @hargaProduk)";
                        foreach (var detail in transaksi.DetailTransaksiList)
                        {
                            using (NpgsqlCommand cmd = new NpgsqlCommand(queryInsertDetail, conn))
                            {
                                cmd.Parameters.AddWithValue("idTransaksi", idTransaksi);
                                cmd.Parameters.AddWithValue("idProduk", detail.IdProduk);
                                cmd.Parameters.AddWithValue("jumlahProduk", detail.JumlahProduk);
                                cmd.Parameters.AddWithValue("hargaProduk", detail.HargaProduk);
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
    }
}
