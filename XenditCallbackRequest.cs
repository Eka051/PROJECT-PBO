using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace COFFE_SHARP
{
    public class XenditCallbackRequest
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("payer_email")]
        public string PayerEmail { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("actions")]
        public List<Action> Actions { get; set; }

        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonPropertyName("checkout_url")]
        public string CheckoutUrl { get; set; }

        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        [JsonPropertyName("checkout_url_expired")]
        public bool CheckoutUrlExpired { get; set; }

        [JsonPropertyName("checkout_data")]
        public CheckoutData CheckoutData { get; set; }
    }

    public class Action
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class CheckoutData
    {
        [JsonPropertyName("success_redirect_url")]
        public string SuccessRedirectUrl { get; set; }

        [JsonPropertyName("failure_redirect_url")]
        public string FailureRedirectUrl { get; set; }
    }
}