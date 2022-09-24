using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace AssignmentHMS.Models
{
    public class Guest
    {
        [Key]
        public Guid guest_id { get; set; }
        public string guest_name { get; set; } = null!;
        public string guest_email { get; set; } = null!;
        public int guest_age { get; set; }
        public long guest_phone_number { get; set; }
        public long guest_aadhar_id { get; set; }
        public string guest_address { get; set; } = null!;
        public virtual ICollection<Reservation>? Reservations { get; set; }
        //public ICollection<Bill> Bills { get; set; } = null!;

    }
}
