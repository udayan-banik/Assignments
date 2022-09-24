namespace AssignmentHMS.Models
{
    public class UpdatePayment
    {
        public long payment_card { get; set; }
        public string payment_card_holder { get; set; } = null!;
    }
}
