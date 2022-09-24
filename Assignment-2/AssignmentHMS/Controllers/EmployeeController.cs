using AssignmentHMS.Data;
using AssignmentHMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreWebAppPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly HMSDbContext dbContext;

        public EmployeeController(HMSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(dbContext.Employees.ToList());
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public IActionResult SearchEmployees(Guid id)
        {
            var emp = dbContext.Employees.Find(id);

            if (emp == null)
            {
                return NotFound();
            }

            return Ok(emp);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void AddEmployee(Employee addEmployee)
        {
            dbContext.Employees.Add(addEmployee);
            dbContext.SaveChanges();
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(Guid id, [FromBody] Employee updateEmployee)
        {
            var emp = dbContext.Employees.Find(id);

            if(emp == null)
            {
                return NotFound();
            }

            emp.employee_name = updateEmployee.employee_name;

            return Ok(dbContext.SaveChanges());

        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public IActionResult RemoveEmployee(Guid id)
        {
            var emp = dbContext.Employees.Find(id);

            if (emp != null)
            {
                dbContext.Remove(emp);
                dbContext.SaveChanges();
                return Ok();
            }

            return NotFound();
        }
    }


    /* employee/add?id=owner/manager
       employee/update?id=owner/manager
       employee/delete?id=owner/manager
       employee/listAllemployee
    */
}
