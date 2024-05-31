using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace COFFE_SHARP
{
    public class QrisPaymentRequest
    {
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("payer_email")]
        public string PayerEmail { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }
    }
}
