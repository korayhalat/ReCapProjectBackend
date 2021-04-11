using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PaymentController : Controller
    {
        IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        [HttpGet("payment")]

        public IActionResult Payment()
        {
            var result = _paymentService.Payment();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }
    }
}
