using AssignmentHMS.Data;
using AssignmentHMS.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreWebAppPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly HMSDbContext dbContext;

        public RoomController(HMSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET: api/<RoomController>
        [HttpGet]
        public IActionResult GetAllRooms()
        {
            return Ok(dbContext.Rooms.ToList());
        }

        // GET api/<RoomController>/5
        [HttpGet("{id}")]
        public IActionResult GetRoom(Guid id)
        {
            var room = dbContext.Rooms.Find(id);

            if(room == null)
            {
                return NotFound();
            }
            return Ok(room);
        }

        // POST api/<RoomController>
        [HttpPost]
        public IActionResult AddRoom(AddRoom _room)
        {
            var room = new Room();
            {
                room.room_status = _room.room_status;
                room.room_comment = _room.room_comment;
                room.room_price = _room.room_price;
                room.room_inventory = _room.room_inventory;
            }

            dbContext.Rooms.Add(room);
            return Ok(dbContext.SaveChanges());
        }

        // PUT api/<RoomController>/5
        [HttpPut("/UpdateRoomStatus/{id}")]
        public IActionResult UpdateRoomStatus(Guid id, UpdateRoom _room)
        {
            var room = dbContext.Rooms.Find(id);

            if (room == null)
            {
                return NotFound();
            }

            room.room_status = _room.room_status;
            return Ok(dbContext.SaveChanges());
        }

        [HttpPut("/UpdateRoomInventory/{id}")]
        public IActionResult UpdateRoomInventory(Guid id, UpdateRoom _room)
        {
            var room = dbContext.Rooms.Find(id);

            if (room == null)
            {
                return NotFound();
            }

            room.room_inventory = _room.room_inventory;
            return Ok(dbContext.SaveChanges());
        }

        [HttpPut("/UpdateRoomComment/{id}")]
        public IActionResult UpdateRoomComment(Guid id, UpdateRoom _room)
        {
            var room = dbContext.Rooms.Find(id);

            if (room == null)
            {
                return NotFound();
            }

            room.room_comment = _room.room_comment;
            return Ok(dbContext.SaveChanges());
        }
        
        [HttpPut("/UpdateRoomPrice/{id}")]
        public IActionResult UpdateRoomPrice(Guid id, UpdateRoom _room)
        {
            var room = dbContext.Rooms.Find(id);

            if (room == null)
            {
                return NotFound();
            }

            room.room_price = _room.room_price;
            return Ok(dbContext.SaveChanges());
        }

        // DELETE api/<RoomController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(Guid id)
        {
            var room = dbContext.Rooms.Find(id);

            if( room == null)
            {
                return NotFound();
            }

            dbContext.Rooms.Remove(room);
            return Ok(dbContext.SaveChanges());
        }
    }

    /* Room Controller 
       /room/add?id=owner/manager
       /room/update?id=owner/manager
       /room/delete?id=owner/manager
       /room/listAllrooms?id=owner/manager/receptionist
    */
}
