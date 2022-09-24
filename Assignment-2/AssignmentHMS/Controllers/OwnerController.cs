using AssignmentHMS.Data;
using AssignmentHMS.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreWebAppPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly HMSDbContext dbContext;

        public OwnerController(HMSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        //[HttpGet]
        //public IActionResult CheckReports(string _ReportType)
        //{
        //    return Ok("Yet to be Completed");
        //}

        //[HttpPost]
        //public IActionResult AddDepartments(string _DepartmentName)
        //{
        //    return Ok("Yet to be Completed");
        //}

        //[HttpPatch]
        //public IActionResult UpdateDepartment(string _DepartmentName)
        //{
        //    var EmployeeDepartment = dbContext.Employees.Find(_DepartmentName);

        //    return Ok(EmployeeDepartment);
        //    //EmployeeController.AddEmployee();
        //    //EmployeeController.UpdateEmployee();
        //    //EmployeeController.RemoveEmployee();

        //    //return Ok("Yet to be Completed");
        //}

        //[HttpDelete]
        //public IActionResult DeleteDepartment(string _DepartmentName)
        //{
        //    //var searchDepartment = Departments.DepartmentName.Find(_DepartmentName);
        //    //if (searchDepartment != null)
        //    //{
        //    //    Departments.Remove(searchDepartment);
        //    //    dbContext.SaveChanges();
        //    //    return Ok(Departments.DepartmentName.ToList());
        //    //}
        //    return Ok("Yet to be Completed");
        //}
    }
}
