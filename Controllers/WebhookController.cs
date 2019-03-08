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
        public IActionResult Post(PaddleBody response)
        {
            return Ok(response);
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
