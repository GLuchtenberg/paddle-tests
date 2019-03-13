using System.Collections.Generic;
using System.Linq;

namespace integrationPaddle.PaddleIntegration
{

    public class Paddle
    {
        public Paddle(IList<KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues>> values)
        {
            alert_name = values.Where(o => o.Key == "alert_name").Select(o => o.Value).First();
            email = values.Where(o => o.Key == "email").Select(o => o.Value).FirstOrDefault();
            balance_currency = values.Where(o => o.Key == "balance_currency").Select(o => o.Value).FirstOrDefault();
            balance_earnings = values.Where(o => o.Key == "balance_earnings").Select(o => o.Value).FirstOrDefault();
            balance_fee = values.Where(o => o.Key == "balance_fee").Select(o => o.Value).FirstOrDefault();
            balance_gross = values.Where(o => o.Key == "balance_gross").Select(o => o.Value).FirstOrDefault();
            balance_tax = values.Where(o => o.Key == "balance_tax").Select(o => o.Value).FirstOrDefault();
            checkout_id = values.Where(o => o.Key == "checkout_id").Select(o => o.Value).FirstOrDefault();
            country = values.Where(o => o.Key == "country").Select(o => o.Value).FirstOrDefault();
            coupon = values.Where(o => o.Key == "coupon").Select(o => o.Value).FirstOrDefault();
            currency = values.Where(o => o.Key == "currency").Select(o => o.Value).FirstOrDefault();
            customer_name = values.Where(o => o.Key == "customer_name").Select(o => o.Value).FirstOrDefault();
            earnings = values.Where(o => o.Key == "earnings").Select(o => o.Value).FirstOrDefault();
            event_time = values.Where(o => o.Key == "event_time").Select(o => o.Value).FirstOrDefault();
            fee = values.Where(o => o.Key == "fee").Select(o => o.Value).FirstOrDefault();
            ip = values.Where(o => o.Key == "ip").Select(o => o.Value).FirstOrDefault();
            marketing_consent = values.Where(o => o.Key == "marketing_consent").Select(o => o.Value).FirstOrDefault();
            order_id = values.Where(o => o.Key == "order_id").Select(o => o.Value).FirstOrDefault();
            passthrough = values.Where(o => o.Key == "passthrough").Select(o => o.Value).FirstOrDefault();
            payment_method = values.Where(o => o.Key == "payment_method").Select(o => o.Value).FirstOrDefault();
            payment_tax = values.Where(o => o.Key == "payment_tax").Select(o => o.Value).FirstOrDefault();
            product_id = values.Where(o => o.Key == "product_id").Select(o => o.Value).FirstOrDefault();
            product_name = values.Where(o => o.Key == "product_name").Select(o => o.Value).FirstOrDefault();
            quantity = values.Where(o => o.Key == "quantity").Select(o => o.Value).FirstOrDefault();
            receipt_url = values.Where(o => o.Key == "receipt_url").Select(o => o.Value).FirstOrDefault();
            sale_gross = values.Where(o => o.Key == "sale_gross").Select(o => o.Value).FirstOrDefault();
            used_price_override = values.Where(o => o.Key == "used_price_override").Select(o => o.Value).FirstOrDefault();
            p_signature = values.Where(o => o.Key == "p_signature").Select(o => o.Value).FirstOrDefault();
        }
        public string alert_name { get; private set; }
        public string balance_currency { get; private set; }
        public string balance_earnings { get; private set; }
        public string balance_fee { get; private set; }
        public string balance_gross { get; private set; }
        public string balance_tax { get; private set; }
        public string checkout_id { get; private set; }
        public string country { get; private set; }
        public string coupon { get; private set; }
        public string currency { get; private set; }
        public string customer_name { get; private set; }
        public string earnings { get; private set; }
        public string email { get; private set; }
        public string event_time { get; private set; }
        public string fee { get; private set; }
        public string ip { get; private set; }
        public string marketing_consent { get; private set; }
        public string order_id { get; private set; }
        public string passthrough { get; private set; }
        public string payment_method { get; private set; }
        public string payment_tax { get; private set; }
        public string product_id { get; private set; }
        public string product_name { get; private set; }
        public string quantity { get; private set; }
        public string receipt_url { get; private set; }
        public string sale_gross { get; private set; }
        public string used_price_override { get; private set; }
        public string p_signature { get; private set; }
    }
}