using COFFE_SHARP.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace COFFE_SHARP
{
    public class XenditService
    {
        private const string XenditApiKey = "xnd_development_WmoNpMI3qE01NkhwZ2FbXZsBVXKIey3KiW4KJsANrSVpBRSjlxd9OJfX3P6fB4";
        private readonly HttpClient httpClient;

        public XenditService()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {XenditApiKey}");
        }

        public async Task<QrCodeResponse> CreateQrisPayment(List<DetailTransaksi> paymentData)
        {
            var paymentRequest = new QrisPaymentRequest
            {
                ExternalId = Guid.NewGuid().ToString(),
                Amount = paymentData.Sum(x => x.TotalHarga),
                PayerEmail = "payer@example.com",
                Description = "Payment for coffee",
                PaymentMethod = "QRIS"
            };

            var json = JsonSerializer.Serialize(paymentRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("https://api.xendit.co/qr_codes", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error creating QRIS payment: {response.ReasonPhrase}");
            }

            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<QrCodeResponse>(responseContent);
        }
    }

}
