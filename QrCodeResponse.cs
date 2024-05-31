using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFE_SHARP
{
    public class QrCodeResponse
    {
        public string id { get; set; }
        public string external_id { get; set; }
        public string qr_string { get; set; }
        public string callback_url { get; set; }
        public int amount { get; set; }
        public string status { get; set; }
        public DateTime created { get; set; }
    }
}
