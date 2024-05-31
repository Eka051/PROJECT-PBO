using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    public class Produk
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public int Id_kategori { get; set; }
        public decimal Harga { get; set; }
        public int Stok { get; set; }
        public byte[] gambarProduk { get; set; }
    }

}
