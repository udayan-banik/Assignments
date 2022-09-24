using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace AssignmentHMS.Models
{
    public class Payment
    {
        [Key]
        public Guid payment_id { get; set; }
        public long payment_card { get; set; }
        public string payment_card_holder { get; set; } = null!;
    }
}
