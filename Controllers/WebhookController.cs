using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
// using Newtonsoft.Json;
// using Newtonsoft.Json.Linq;

namespace integrationPaddle.Controllers
{
    public class PaddleBody
    {
        public PaddleBody(){
            // alert_name = values.Where(o => o.Key == "alert_name").Select(o => o.Value).First(),
            //     balance_currency = values.Where(o => o.Key == "balance_currency").Select(o => o.Value).First(),
            //     balance_earnings = values.Where(o => o.Key == "balance_earnings").Select(o => o.Value).First(),
            //     balance_fee = values.Where(o => o.Key == "balance_fee").Select(o => o.Value).First(),
            //     balance_gross = values.Where(o => o.Key == "balance_gross").Select(o => o.Value).First(),
            //     balance_tax = values.Where(o => o.Key == "balance_tax").Select(o => o.Value).First(),
            //     checkout_id = values.Where(o => o.Key == "checkout_id").Select(o => o.Value).First(),
            //     country = values.Where(o => o.Key == "country").Select(o => o.Value).First(),
            //     coupon = values.Where(o => o.Key == "coupon").Select(o => o.Value).First(),
            //     currency = values.Where(o => o.Key == "currency").Select(o => o.Value).First(),
            //     customer_name = values.Where(o => o.Key == "customer_name").Select(o => o.Value).First(),
            //     earnings = values.Where(o => o.Key == "earnings").Select(o => o.Value).First(),
            //     email = values.Where(o => o.Key == "email").Select(o => o.Value).First(),
            //     event_time = values.Where(o => o.Key == "event_time").Select(o => o.Value).First(),
            //     fee = values.Where(o => o.Key == "fee").Select(o => o.Value).First(),
            //     ip = values.Where(o => o.Key == "ip").Select(o => o.Value).First(),
            //     marketing_consent = values.Where(o => o.Key == "marketing_consent").Select(o => o.Value).First(),
            //     order_id = values.Where(o => o.Key == "order_id").Select(o => o.Value).First(),
            //     passthrough = values.Where(o => o.Key == "passthrough").Select(o => o.Value).First(),
            //     payment_method = values.Where(o => o.Key == "payment_method").Select(o => o.Value).First(),
            //     payment_tax = values.Where(o => o.Key == "payment_tax").Select(o => o.Value).First(),
            //     product_id = values.Where(o => o.Key == "product_id").Select(o => o.Value).First(),
            //     product_name = values.Where(o => o.Key == "product_name").Select(o => o.Value).First(),
            //     quantity = values.Where(o => o.Key == "quantity").Select(o => o.Value).First(),
            //     receipt_url = values.Where(o => o.Key == "receipt_url").Select(o => o.Value).First(),
            //     sale_gross = values.Where(o => o.Key == "sale_gross").Select(o => o.Value).First(),
            //     used_price_override = values.Where(o => o.Key == "used_price_override").Select(o => o.Value).First(),
            //     p_signature = values.Where(o => o.Key == "p_signature").Select(o => o.Value).First(),
        }
        public string alert_name { get; set; }
        public string balance_currency { get; set; }
        public string balance_earnings { get; set; }
        public string balance_fee { get; set; }
        public string balance_gross { get; set; }
        public string balance_tax { get; set; }
        public string checkout_id { get; set; }
        public string country { get; set; }
        public string coupon { get; set; }
        public string currency { get; set; }
        public string customer_name { get; set; }
        public string earnings { get; set; }
        public string email { get; set; }
        public string event_time { get; set; }
        public string fee { get; set; }
        public string ip { get; set; }
        public string marketing_consent { get; set; }
        public string order_id { get; set; }
        public string passthrough { get; set; }
        public string payment_method { get; set; }
        public string payment_tax { get; set; }
        public string product_id { get; set; }
        public string product_name { get; set; }
        public string quantity { get; set; }
        public string receipt_url { get; set; }
        public string sale_gross { get; set; }
        public string used_price_override { get; set; }
        public string p_signature { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class WebhookController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        [Consumes("application/x-www-form-urlencoded")]
        public IActionResult Post([FromForm] string data)
        // object response
        {
            var values = Request.Form.Select(v => v).ToList();
            var paddle = new PaddleBody()
            {
                alert_name = values.Where(o => o.Key == "alert_name").Select(o => o.Value).First(),
                balance_currency = values.Where(o => o.Key == "balance_currency").Select(o => o.Value).First(),
                balance_earnings = values.Where(o => o.Key == "balance_earnings").Select(o => o.Value).First(),
                balance_fee = values.Where(o => o.Key == "balance_fee").Select(o => o.Value).First(),
                balance_gross = values.Where(o => o.Key == "balance_gross").Select(o => o.Value).First(),
                balance_tax = values.Where(o => o.Key == "balance_tax").Select(o => o.Value).First(),
                checkout_id = values.Where(o => o.Key == "checkout_id").Select(o => o.Value).First(),
                country = values.Where(o => o.Key == "country").Select(o => o.Value).First(),
                coupon = values.Where(o => o.Key == "coupon").Select(o => o.Value).First(),
                currency = values.Where(o => o.Key == "currency").Select(o => o.Value).First(),
                customer_name = values.Where(o => o.Key == "customer_name").Select(o => o.Value).First(),
                earnings = values.Where(o => o.Key == "earnings").Select(o => o.Value).First(),
                email = values.Where(o => o.Key == "email").Select(o => o.Value).First(),
                event_time = values.Where(o => o.Key == "event_time").Select(o => o.Value).First(),
                fee = values.Where(o => o.Key == "fee").Select(o => o.Value).First(),
                ip = values.Where(o => o.Key == "ip").Select(o => o.Value).First(),
                marketing_consent = values.Where(o => o.Key == "marketing_consent").Select(o => o.Value).First(),
                order_id = values.Where(o => o.Key == "order_id").Select(o => o.Value).First(),
                passthrough = values.Where(o => o.Key == "passthrough").Select(o => o.Value).First(),
                payment_method = values.Where(o => o.Key == "payment_method").Select(o => o.Value).First(),
                payment_tax = values.Where(o => o.Key == "payment_tax").Select(o => o.Value).First(),
                product_id = values.Where(o => o.Key == "product_id").Select(o => o.Value).First(),
                product_name = values.Where(o => o.Key == "product_name").Select(o => o.Value).First(),
                quantity = values.Where(o => o.Key == "quantity").Select(o => o.Value).First(),
                receipt_url = values.Where(o => o.Key == "receipt_url").Select(o => o.Value).First(),
                sale_gross = values.Where(o => o.Key == "sale_gross").Select(o => o.Value).First(),
                used_price_override = values.Where(o => o.Key == "used_price_override").Select(o => o.Value).First(),
                p_signature = values.Where(o => o.Key == "p_signature").Select(o => o.Value).First(),
            };
            
            return Ok(paddle);
        }
            // var dict = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(uri.Query);
            // responses.Add(dict);
            // SortedDictionary<string, dynamic> padStuff = new SortedDictionary<string, dynamic>();
            // JObject obj = JObject.Parse(dict);
            // PaddleBody body = obj.ToObject<PaddleBody>();
            // var teste = ObjectFromDictionary<PaddleBody>(dict);
        // var dict = Request.Form.ToDictionary(x => x.Key, x => x.Value.ToString());
        // private T ObjectFromDictionary<T>(IDictionary<string, string> dict)
        //     where T : class
        // {
        //     Type type = typeof(T);
        //     T result = (T)Activator.CreateInstance(type);
        //     foreach (var item in dict)
        //     {
        //         type.GetProperty(item.Key).SetValue(result, item.Value, null);
        //     }
        //     return result;
        // }

        public string PaymentSuccess(string type)
        {
            return "1";
        }
        public string PaymentRefunded(string type)
        {
            return "2";
        }
        //formdata get datas
        //parse formdata aspnetcore
    }
}
