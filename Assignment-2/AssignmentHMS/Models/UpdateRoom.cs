namespace AssignmentHMS.Models
{
    public class UpdateRoom
    {
        public bool room_status { get; set; }
        public string room_comment { get; set; } = null!;
        public string room_inventory { get; set; } = null!;
        public float room_price { get; set; }
    }
}
