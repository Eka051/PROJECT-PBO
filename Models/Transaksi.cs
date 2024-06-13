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
        public string NamaAdmin { get; set; }
        public decimal TotalHarga { get; set; }
        public int IdPembayaran { get; set; }
        public List<DetailTransaksi> DetailTransaksiList { get; set; }
    }

    public class DetailTransaksi
    {
        public int IdDetailTransaksi { get; set; }
        public int IdProduk { get; set; }
        public string NamaProduk { get; set; }
        public int JumlahProduk { get; set; }
        public decimal HargaProduk { get; set; }
    }

    public class DataPembayaran
    {
        public int IdPembayaran { get; set; }
        public decimal JumlahPembayaran { get; set; }
        public int IdMetode { get; set; }
    }

    public class Rekap
    {
        public double Weekly { get; set; }
        public double Monthly { get; set; }
        public double Dipilih { get; set; }
        public double Harian { get; set; } 
    }
}
