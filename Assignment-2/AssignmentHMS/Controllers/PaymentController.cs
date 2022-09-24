using AssignmentHMS.Data;
using AssignmentHMS.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreWebAppPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly HMSDbContext dbContext;

        public PaymentController(HMSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // POST api/<PaymentController>
        [HttpPost]
        public IActionResult Post(Payment addPayment)
        {

            dbContext.Payments.Add(addPayment);
            dbContext.SaveChanges();

            return Ok(dbContext.Payments.ToList());
        }

    }

    /* Payment Controllers
       payment/add
       payment/update
    */
}
