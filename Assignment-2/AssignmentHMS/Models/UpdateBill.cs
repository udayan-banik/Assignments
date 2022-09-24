namespace AssignmentHMS.Models
{
    public class UpdateBill
    {
        public double bill_amount { get; set; }
        public DateTime bill_date { get; set; }
        public virtual ICollection<Payment>? Payments { get; set; }

        public virtual ICollection<Room>? Rooms { get; set; }
    }
}
