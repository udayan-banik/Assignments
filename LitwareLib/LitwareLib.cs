namespace LitwareLib
{
    public class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;

        public void RegisterEmployee(int EmpNo, string EmpName, double Salary)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.Salary = Salary;

            if (Salary < 5000)
            {
                HRA = Salary * 0.1;
                TA = Salary * 0.05;
                DA = Salary * 0.15;
            }
            else if (Salary < 10000)
            {
                HRA = Salary * 0.15;
                TA = Salary * 0.10;
                DA = Salary * 0.2;
            }


            else if (Salary < 15000)
            {
                HRA = Salary * 0.2;
                TA = Salary * 0.15;
                DA = Salary * 0.25;
            }
            else if (Salary < 20000)
            {
                HRA = Salary * 0.25;
                TA = Salary * 0.20;
                DA = Salary * 0.30;
            }

            else if (Salary >= 20000)
            {
                HRA = Salary * 0.30;
                TA = Salary * 0.25;
                DA = Salary * 0.35;
            }

            this.GrossSalary = Salary + HRA + TA + DA;

        }

        public void showGrossSalary()
        {
            Console.WriteLine("The GrossSalary of " + EmpName + " is : "+ GrossSalary);
        }

        public void CalculateSalary()
        {
            PF = 0.10 * GrossSalary;
            TDS = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (PF + TDS);
        }
    }
}