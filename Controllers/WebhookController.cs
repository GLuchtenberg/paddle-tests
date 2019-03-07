using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace integrationPaddle.Controllers
{
    public class PaddleBody
    {
        string AlertName;
        string BalanceCurrency;
        string BalanceEarnings;
        string BalanceFee;
        string BalanceGross;
        string BalanceTax;
        string CheckoutId;
        string Country;
        string Coupon;
        string Currency;
        string CustomerName;
        string Earnings;
        string Email;
        string EventTime;
        string Fee;
        string Ip;
        string MarketingConsent;
        string OrderId;
        string Passthrough;
        string PaymentMethod;
        string PaymentTax;
        string ProductId;
        string ProductName;
        string Quantity;
        string ReceiptUrl;
        string SaleGross;
        string UsedPriceOverride;
        string PSignature;
    }

    [Route("api/[controller]")]
    [ApiController]
    public class WebhookController : ControllerBase
    {


        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] PaddleBody paddle)
        {
            return Ok(paddle);
        }

    }
}
