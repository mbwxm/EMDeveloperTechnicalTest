using DevelopmentTechnicalTestBackend.Attributes;
using DevelopmentTechnicalTestBackend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DevelopmentTechnicalTestBackend.Controllers
{
    [Route("api/payment")]
    [ApiController]
    [ApiKey] 
    public class PaymentController : ControllerBase
    {
        // POST api/payment
        [HttpPost]
        [Authorize]
        public IActionResult Index([FromForm] Payment payment)
        {
            if (ModelState.IsValid)
            {
                var createdPayment = new PaymentService().Create(payment);
                return Content(string.Format("Successfully saved:\n{0}\n{1}\n{2}\n{3}\n{4}", createdPayment.ID, createdPayment.To, createdPayment.From, createdPayment.Amount, createdPayment.DateToSend));                
            }
            return Index(payment);
        }
    }
}
