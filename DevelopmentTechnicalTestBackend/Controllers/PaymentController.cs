using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
            return Ok("BeepBoop");
        }
    }
}
