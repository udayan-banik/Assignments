using System.ComponentModel.DataAnnotations;

namespace AssignmentHMS.Models
{
    public class Owner
    {
        [Key]
        public int login_id { get; set; }
        public string login_password { get; set; } = null!;
    }
}
