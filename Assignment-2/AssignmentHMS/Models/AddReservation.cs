namespace AssignmentHMS.Models
{
    public class AddReservation
    {
        public DateTime reservation_check_in { get; set; }
        public DateTime reservation_check_out { get; set; }
        public int reservation_no_of_guests { get; set; }
    }
}
