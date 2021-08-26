using DevelopmentTechnicalTestBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopmentTechnicalTestBackend.Controllers
{
    [Route("api/payment")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        // POST api/payment
        [HttpPost]
        public IActionResult Post([FromBody] object value)
        {
            return Ok();
        }
    }
}
