using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentHMS.Models
{
    public class Bill
    {
        [Key]
        public Guid bill_id { get; set; }
        public double bill_amount { get; set; }
        public DateTime bill_date { get; set; }
        public virtual ICollection<Payment>? Payments { get; set; }

        public virtual ICollection<Room>? Rooms { get; set; }

    }
}
