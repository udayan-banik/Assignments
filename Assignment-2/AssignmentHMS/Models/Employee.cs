using System.ComponentModel.DataAnnotations;

namespace AssignmentHMS.Models
{
    public class Employee
    {
        [Key]
        public Guid employee_id { get; set; }
        public string employee_designation { get; set; }
        public string employee_password { get; set; }
        public double employee_salary { get; set; }
        public string employee_name { get; set; }
        public int employee_email { get; set; }
        public int employee_number { get; set; }
        public int employee_age { get; set; }
        public string employee_address { get; set; }
    }
}
