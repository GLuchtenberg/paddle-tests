using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using integrationPaddle.PaddleIntegration;


namespace integrationPaddle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebhookController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            var values = Request.Form.Select(v => v).ToList();
            var paddle = new Paddle(values);
            PaddleAction action = PaddleActionFactory.Create(paddle);
            action.Resolve();
            return Ok(action.Resolve());
        }
    }
}
