using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitwareLib;

namespace LitwareLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Registration
            Console.WriteLine("Enter Employee Number:");
            int emp_no = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter Employee Name:");
            string emp_name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary:");
            double emp_salary = double.Parse(Console.ReadLine());

        }
    }
}
