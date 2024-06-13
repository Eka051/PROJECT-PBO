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
        void TransaksiProduk(int idProduk, int stok);
        int GenerateIdProduk();
        int GetIdKategori(string namaKategori);
        List<string> GetAllNamaKategori();
        List<string> GetNamaKategori(int idKategori);
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
            string query_select = "SELECT id_produk, nama_produk, harga, stok, gambar_produk FROM produk ORDER BY id_produk";

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
            string query_insert = "INSERT INTO produk (id_produk, nama_produk, kategori_id, harga, stok, gambar_produk) VALUES (@id, @nama, @kategori_id, @harga, @stok, @gambarProduk)";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query_insert, conn))
                {
                    cmd.Parameters.AddWithValue("id", produk.Id);
                    cmd.Parameters.AddWithValue("nama", produk.Nama);
                    cmd.Parameters.AddWithValue("kategori_id", produk.Id_kategori);
                    cmd.Parameters.AddWithValue("harga", produk.Harga);
                    cmd.Parameters.AddWithValue("stok", produk.Stok);
                    cmd.Parameters.AddWithValue("gambarProduk", produk.gambarProduk);
                    cmd.ExecuteNonQuery();
                }
            }

            OnProdukDiubah(EventArgs.Empty);
        }

        public void HapusProduk(int id)
        {
            string query_delete_detail = "DELETE FROM detail_transaksi WHERE id_produk = @id";
            string query_delete_produk = "DELETE FROM produk WHERE id_produk = @id";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        using (NpgsqlCommand cmd = new NpgsqlCommand(query_delete_detail, conn))
                        {
                            cmd.Parameters.AddWithValue("id", id);
                            cmd.ExecuteNonQuery();
                        }

                        using (NpgsqlCommand cmd = new NpgsqlCommand(query_delete_produk, conn))
                        {
                            cmd.Parameters.AddWithValue("id", id);
                            cmd.ExecuteNonQuery();
                        }

                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw new Exception("Error deleting product", ex);
                    }
                }
            }

            OnProdukDiubah(EventArgs.Empty);
        }


        public void EditProduk(Produk produk)
        {
            string query_update = @"UPDATE produk SET nama_produk = @nama_produk, kategori_id = @Id_kategori, 
                            harga = @harga, stok = @stok, gambar_produk = @gambarProduk WHERE id_produk = @id";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query_update, conn))
                {
                    cmd.Parameters.AddWithValue("id", produk.Id);
                    cmd.Parameters.AddWithValue("nama_produk", produk.Nama);
                    cmd.Parameters.AddWithValue("Id_kategori", produk.Id_kategori);
                    cmd.Parameters.AddWithValue("harga", produk.Harga);
                    cmd.Parameters.AddWithValue("stok", produk.Stok);
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

        public int GetIdKategori(string namaKategori)
        {
            string query_getIdKategori = "SELECT id_kategori FROM kategori WHERE nama_kategori = @namaKategori";
            int idKategori;

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query_getIdKategori, conn))
                {
                    cmd.Parameters.AddWithValue("namaKategori", namaKategori);
                    object result = cmd.ExecuteScalar();
                    idKategori = result != null ? (int)result : 0;
                }
            }

            return idKategori;
        }

        public List<string> GetNamaKategori(int idKategori)
        {
            List<string> namaKategoriList = new List<string>();

            string query = "SELECT nama_kategori FROM kategori WHERE id_kategori = @idKategori";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idKategori", idKategori);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string namaKategori = reader.GetString(0);
                            namaKategoriList.Add(namaKategori);
                        }
                    }
                }
            }

            return namaKategoriList;
        }

        public List<string> GetAllNamaKategori()
        {
            List<string> namaKategoriList = new List<string>();

            string query = "SELECT nama_kategori FROM kategori";

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string namaKategori = reader.GetString(0);
                            namaKategoriList.Add(namaKategori);
                        }
                    }
                }
            }

            return namaKategoriList;
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

        

        public void TransaksiProduk(int idProduk, int jumlahTerjual)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                using (var transaksiProduk = conn.BeginTransaction())
                {
                    try
                    {
                        string query_getStok = "SELECT stok FROM produk WHERE id_produk = @id";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(query_getStok, conn))
                        {
                            cmd.Parameters.AddWithValue("id", idProduk);
                            int currentStok = (int)cmd.ExecuteScalar();

                            if (currentStok >= jumlahTerjual)
                            {
                                string query_updateStok = "UPDATE produk SET stok = stok - @jumlah WHERE id_produk = @id";
                                using (NpgsqlCommand cmd_update = new NpgsqlCommand(query_updateStok, conn))
                                {
                                    cmd_update.Parameters.AddWithValue("id", idProduk);
                                    cmd_update.Parameters.AddWithValue("jumlah", jumlahTerjual);
                                    cmd_update.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                string query_setStokToZero = "UPDATE produk SET stok = 0 WHERE id_produk = @id";
                                using (NpgsqlCommand cmd_update = new NpgsqlCommand(query_setStokToZero, conn))
                                {
                                    cmd_update.Parameters.AddWithValue("id", idProduk);
                                    cmd_update.ExecuteNonQuery();
                                }
                            }
                        }
                        transaksiProduk.Commit();
                    }
                    catch (Exception)
                    {
                        transaksiProduk.Rollback();
                        throw;
                    }
                }
            }
            OnProdukDiubah(EventArgs.Empty);
        }

    }
}
