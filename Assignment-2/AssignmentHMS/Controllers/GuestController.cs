using AssignmentHMS.Data;
using AssignmentHMS.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreWebAppPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly HMSDbContext dbContext;

        public GuestController(HMSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllGuest()
        {
            return Ok(dbContext.Guests.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetUniqueGuest(Guid id)
        {
            var search = dbContext.Guests.Find(id);

            if(search == null)
            {
                return NotFound();
            }

            return Ok(search);
        }
        // POST api/<GuestController>
        [HttpPost]
        public IActionResult Post(Guest guest)
        {
            if(guest.Reservations == null)
                guest.Reservations = new List<Reservation>();

            dbContext.Guests.Add(guest);
            dbContext.SaveChanges();

            return Ok(dbContext.Guests.ToList());
        }

        // PUT api/<GuestController>/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Guest _guest)
        {
            var guest = dbContext.Guests.Find(id);

            if (guest == null)
            {
                return NotFound();
            }

            guest = _guest;

            return Ok(dbContext.SaveChanges());
        }

    }

    /* Guest Controller
     /guest/add
     /guest/update
     */
}
