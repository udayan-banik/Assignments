using System.ComponentModel.DataAnnotations;

namespace AssignmentHMS.Models
{
    public class Reservation
    {
        [Key]
        public Guid reservation_id { get; set; }
        public DateTime reservation_check_in { get; set; }
        public DateTime reservation_check_out { get; set; }
        public int reservation_no_of_guests { get; set; }
        //public Room Room { get; set; } = null!;
        //public Guest Guest { get; set; } = null!;
        public virtual ICollection<Bill>? Bills { get; set; }
    }
}
