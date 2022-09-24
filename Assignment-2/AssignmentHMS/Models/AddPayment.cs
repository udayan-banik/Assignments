namespace AssignmentHMS.Models
{
    public class AddPayment
    {
        public long payment_card { get; set; }
        public string payment_card_holder { get; set; } = null!;
    }
}
