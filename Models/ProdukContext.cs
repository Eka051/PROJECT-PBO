using Npgsql;
using System;
using System.Collections.Generic;

namespace COFFE_SHARP.Models
{
    public interface IProdukContext
    {
        List<Produk> GetProdukFromDatabase();
        void TambahProduk(Produk produk);
        void HapusProduk(int id);
        void EditProduk(Produk produk);
        void UpdateStok(int idProduk, int stok);
        int GenerateIdProduk();
        long TotalProduk();
        event EventHandler? ProdukDiubah;
    }

    public class ProdukContext : IProdukContext
    {
        private readonly string connStr;
        public event EventHandler? ProdukDiubah;

        public ProdukContext()
        {
            connStr = "Host=localhost;Username=postgres;Password=dianeka@05;Database=CoffeSharp";
        }

        protected virtual void OnProdukDiubah(EventArgs e)
        {
            ProdukDiubah?.Invoke(this, e);
        }

        public List<Produk> GetProdukFromDatabase()
        {
            var listProduk = new List<Produk>();
            string query_select = "SELECT id_produk, nama, harga, stok, tanggal_exp, gambar_produk FROM produk ORDER BY id_produk";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query_select, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Produk produk = new Produk
                            {
                                Id = reader.GetInt32(0),
                                Nama = reader.GetString(1),
                                Harga = reader.GetDecimal(2),
                                Stok = reader.GetInt32(3),
                                TanggalExp = reader.GetDateTime(4),
                                gambarProduk = reader["gambar_produk"] as byte[] ?? new byte[0]
                            };
                            listProduk.Add(produk);
                        }
                    }
                }
            }
            return listProduk;
        }

        public void TambahProduk(Produk produk)
        {
            string query_insert = "INSERT INTO produk (id_produk, nama, harga, stok, tanggal_exp, gambar_produk) VALUES (@id, @nama, @harga, @stok, @tanggalExp, @gambarProduk)";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query_insert, conn))
                {
                    cmd.Parameters.AddWithValue("id", produk.Id);
                    cmd.Parameters.AddWithValue("nama", produk.Nama);
                    cmd.Parameters.AddWithValue("harga", produk.Harga);
                    cmd.Parameters.AddWithValue("stok", produk.Stok);
                    cmd.Parameters.AddWithValue("tanggalExp", produk.TanggalExp);
                    cmd.Parameters.AddWithValue("gambarProduk", produk.gambarProduk);
                    cmd.ExecuteNonQuery();
                }
            }

            OnProdukDiubah(EventArgs.Empty);
        }

        public void HapusProduk(int id)
        {
            string query_delete = "DELETE FROM produk WHERE id_produk = @id";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query_delete, conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            OnProdukDiubah(EventArgs.Empty);
        }

        public void EditProduk(Produk produk)
        {
            string query_update = "UPDATE produk SET nama = @nama, harga = @harga, stok = @stok, tanggal_exp = @tanggalExp, gambar_produk = @gambarProduk WHERE id_produk = @id";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query_update, conn))
                {
                    cmd.Parameters.AddWithValue("id", produk.Id);
                    cmd.Parameters.AddWithValue("nama", produk.Nama);
                    cmd.Parameters.AddWithValue("harga", produk.Harga);
                    cmd.Parameters.AddWithValue("stok", produk.Stok);
                    cmd.Parameters.AddWithValue("tanggalExp", produk.TanggalExp);
                    cmd.Parameters.AddWithValue("gambarProduk", produk.gambarProduk);
                    cmd.ExecuteNonQuery();
                }
            }

            OnProdukDiubah(EventArgs.Empty);
        }

        public void UpdateStok(int idProduk, int stok)
        {
            string query_updateStok = "UPDATE produk SET stok = @stok WHERE id_produk = @id";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query_updateStok, conn))
                {
                    cmd.Parameters.AddWithValue("id", idProduk);
                    cmd.Parameters.AddWithValue("stok", stok);
                    cmd.ExecuteNonQuery();
                }
            }

            OnProdukDiubah(EventArgs.Empty);
        }


        public int GenerateIdProduk()
        {
            string query_maxId = "SELECT COALESCE(MAX(id_produk), 0) FROM produk";
            int maxId;

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query_maxId, conn))
                {
                    maxId = (int)cmd.ExecuteScalar();
                }
            }

            return maxId + 1;
        }

        public long TotalProduk()
        {
            string query_count = "SELECT COUNT(*) FROM produk";
            long totalProduk;

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query_count, conn))
                {
                    totalProduk = (long)cmd.ExecuteScalar();
                }
            }

            return totalProduk;
        }
    }

}
