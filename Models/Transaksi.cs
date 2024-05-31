using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP.Models
{
    public class Transaksi
    {
        public int IdTransaksi { get; set; }
        public DateTime TanggalTransaksi { get; set; }
        public int IdAdmin { get; set; }
        public decimal TotalHarga { get; set; }
        public int IdPembayaran { get; set; }
        public List<DetailTransaksi> DetailTransaksiList { get; set; }
    }

    public class DetailTransaksi
    {
        public int IdDetailTransaksi { get; set; }
        public int IdProduk { get; set; }
        public int JumlahProduk { get; set; }
        public decimal HargaProduk { get; set; }
    }
}
