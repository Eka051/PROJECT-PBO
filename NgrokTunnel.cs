using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace COFFE_SHARP
{
    public class NgrokTunnel
    {
        [JsonPropertyName("https://4b17-140-213-118-123.ngrok-free.app")]
        public string PublicUrl { get; set; }
    }
}
