using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitwareLib;

namespace EventManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Registration
                Console.WriteLine("*** Enter the new joinee details ***");
                Console.WriteLine("Enter Employee Number:");
                int emp_no = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name:");
                string emp_name = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary:");
                double emp_salary = double.Parse(Console.ReadLine());

                //Create an Employee entry on Joining
                Employee emp = new Employee();
                emp.RegisterEmployee(emp_no, emp_name, emp_salary);
                emp.showGrossSalary();

                ////Generate List of Employees 
                //List<Employee> employees = new List<Employee>();
                //employees.Add(emp);}
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

