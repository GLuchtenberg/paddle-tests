using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
// using Newtonsoft.Json;
// using Newtonsoft.Json.Linq;

namespace integrationPaddle.Controllers
{
    public class PaddleBody
    {
        string alert_name { get; set; }
        // string AlertName { get; set; }
        // string BalanceCurrency { get; set; }
        // string BalanceEarnings { get; set; }
        // string BalanceFee { get; set; }
        // string BalanceGross { get; set; }
        // string BalanceTax { get; set; }
        // string CheckoutId { get; set; }
        // string Country { get; set; }
        // string Coupon { get; set; }
        // string Currency { get; set; }
        // string CustomerName { get; set; }
        // string Earnings { get; set; }
        // string Email { get; set; }
        // string EventTime { get; set; }
        // string Fee { get; set; }
        // string Ip { get; set; }
        // string MarketingConsent { get; set; }
        // string OrderId { get; set; }
        // string Passthrough { get; set; }
        // string PaymentMethod { get; set; }
        // string PaymentTax { get; set; }
        // string ProductId { get; set; }
        // string ProductName { get; set; }
        // string Quantity { get; set; }
        // string ReceiptUrl { get; set; }
        // string SaleGross { get; set; }
        // string UsedPriceOverride { get; set; }
        // string PSignature { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class WebhookController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public IActionResult Post()
        {
            // var teste =JsonConvert.DeserializeObject<PaddleBody>(Request.Body.ToString());
            var meuObject = JsonConvert.DeserializeObject<object>(Request.Body.ToString());

            var oMeuDeusPlease = (PaddleBody)meuObject;
            return Ok(oMeuDeusPlease);
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
