using AssignmentHMS.Data;
using AssignmentHMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssignmentHMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly HMSDbContext dbContext;

        public BillController(HMSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpPost]
        public IActionResult IssueBill(AddBill _createBill)
        {
            var createBill = new Bill();
            {
                createBill.bill_amount = _createBill.bill_amount;
                createBill.bill_date = _createBill.bill_date;
            };

            dbContext.Bills.Add(createBill);
            return Ok(dbContext.Bills.ToList());
        }
    }

    /* Bill Controllers 
     bill/generate
     */

}
