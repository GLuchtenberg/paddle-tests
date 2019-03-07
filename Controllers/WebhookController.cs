using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace integrationPaddle.Controllers
{
    public class PaddleBody {

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
