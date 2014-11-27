﻿using Newtonsoft.Json;

namespace Coinbase.ObjectModel
{
    public class Button
    {
        public string type { get; set; }
        public bool subscription { get; set; }
        public object repeat { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string id { get; set; }
    }

    public class OrderRefundResponseDetails
    {
        public string id { get; set; }
        public string created_at { get; set; }
        public string status { get; set; }
        public object @event { get; set; }

        [JsonProperty("total_btc")]
        public Price TotalBtc { get; set; }

        [JsonProperty("total_native")]
        public Price TotalNative { get; set; }

        [JsonProperty("total_payout")]
        public Price TotalPayout { get; set; }
        public string custom { get; set; }
        public string receive_address { get; set; }
        public Button button { get; set; }
        public Transaction Transaction { get; set; }
        [JsonProperty("refund_transaction")]
        public Transaction RefundTransaction { get; set; }
    }

    /// <summary>
    ///If the order has status completed and the refund processed successfully, the order data will contain the refund transaction details in RefundTransaction.
    /// </summary>
    public class RefundResponse
    {
        [JsonProperty("order")]
        public OrderRefundResponseDetails Order { get; set; }
    }
}
