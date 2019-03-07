using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace integrationPaddle.Controllers
{
    public class PaddleBody
    {
        public string AlertName { get; set; }
        public string BalanceCurrency { get; set; }
        public string BalanceEarnings { get; set; }
        public string BalanceFee { get; set; }
        public string BalanceGross { get; set; }
        public string BalanceTax { get; set; }
        public string CheckoutId { get; set; }
        public string Country { get; set; }
        public string Coupon { get; set; }
        public string Currency { get; set; }
        public string CustomerName { get; set; }
        public string Earnings { get; set; }
        public string Email { get; set; }
        public string EventTime { get; set; }
        public string Fee { get; set; }
        public string Ip { get; set; }
        public string MarketingConsent { get; set; }
        public string OrderId { get; set; }
        public string Passthrough { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentTax { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Quantity { get; set; }
        public string ReceiptUrl { get; set; }
        public string SaleGross { get; set; }
        public string UsedPriceOverride { get; set; }
        public string PSignature { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class WebhookController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public IActionResult Post()
        {
            // JsonConvert.DeserializeObject<PaddleBody>(
            var dict = Request.Form;
            JObject obj = JObject.Parse(dict.ToString());
            PaddleBody body = obj.ToObject<PaddleBody>();
            // var dict = Request.Form.ToDictionary(x => x.Key, x => x.Value.ToString());
            // var teste = ObjectFromDictionary<PaddleBody>(dict);
            
            return Ok(body.AlertName);
        }
        private T ObjectFromDictionary<T>(IDictionary<string, string> dict)
            where T : class 
        {
            Type type = typeof(T);
            T result = (T)Activator.CreateInstance(type);
            foreach (var item in dict)
            {
                type.GetProperty(item.Key).SetValue(result, item.Value, null);
            }
            return result;
        }

        public string PaymentSuccess(string type){
            return "1";
        }
        public string PaymentRefunded(string type){
            return "2";
        }
//formdata get datas
//parse formdata aspnetcore
    }
}
