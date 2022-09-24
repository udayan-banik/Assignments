using AssignmentHMS.Data;
using AssignmentHMS.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreWebAppPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly HMSDbContext dbContext;

        public ReservationController(HMSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        [HttpGet]
        public IActionResult GetAllReservations()
        {
            return Ok(dbContext.Reservations.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetReservationByGuestId(Guid id)
        {
            var search = dbContext.Guests.Find(id);

            if(search == null)
            {
                return NotFound();
            }

            return Ok(search.Reservations.ToList());
        }

        // POST api/<ReservationController>
        [HttpPost]
        public IActionResult MakeReservation(Guid id, AddReservation _reservation)
        {
            var isAvailable = dbContext.Rooms.Find(id);

            if(isAvailable == null || isAvailable.room_status == false)
            {
                return NotFound();
            }

            var reservation = new Reservation();
            {
                reservation.reservation_check_in = _reservation.reservation_check_in;
                reservation.reservation_check_out = _reservation.reservation_check_out;
                reservation.reservation_no_of_guests = _reservation.reservation_no_of_guests;
            }

            dbContext.Reservations.Add(reservation);

            isAvailable.room_status = false;

            dbContext.SaveChanges();

            return Ok(dbContext.Reservations.ToList());
        }

    }

    /* Reservation Controller:
       /reservation/add
       /reservation/update
       /reservation/delete
    */
}
