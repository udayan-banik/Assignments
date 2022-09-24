using System.ComponentModel.DataAnnotations;

namespace AssignmentHMS.Models
{
    public class Room
    {
        [Key]
        public Guid room_id { get; set; }
        public bool room_status { get; set; }
        public string room_comment { get; set; } = null!;
        public string room_inventory { get; set; } = null!;
        public float room_price { get; set; }
        //foreign key ref
        //public ICollection<Reservation> Reservations { get; set; } = null!;
    }
}
