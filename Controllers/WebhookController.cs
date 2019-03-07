using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace integrationPaddle.Controllers
{
    // public class PaddleBody
    // {
    //     string AlertName { get; set; }
    //     string BalanceCurrency { get; set; }
    //     string BalanceEarnings { get; set; }
    //     string BalanceFee { get; set; }
    //     string BalanceGross { get; set; }
    //     string BalanceTax { get; set; }
    //     string CheckoutId { get; set; }
    //     string Country { get; set; }
    //     string Coupon { get; set; }
    //     string Currency { get; set; }
    //     string CustomerName { get; set; }
    //     string Earnings { get; set; }
    //     string Email { get; set; }
    //     string EventTime { get; set; }
    //     string Fee { get; set; }
    //     string Ip { get; set; }
    //     string MarketingConsent { get; set; }
    //     string OrderId { get; set; }
    //     string Passthrough { get; set; }
    //     string PaymentMethod { get; set; }
    //     string PaymentTax { get; set; }
    //     string ProductId { get; set; }
    //     string ProductName { get; set; }
    //     string Quantity { get; set; }
    //     string ReceiptUrl { get; set; }
    //     string SaleGross { get; set; }
    //     string UsedPriceOverride { get; set; }
    //     string PSignature { get; set; }
    // }

    [Route("api/[controller]")]
    [ApiController]
    public class WebhookController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public IActionResult Post()
        {
            var dict = Request.Form.ToDictionary(x => x.Key, x => x.Value.ToString());
            
            // if(dict.alert_name === 'payment_succeeded'){
                
            // }
            // if(dict.alert_name === 'payment_succeeded'){

            // }
            return Ok(dict);
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
