using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_OOP_
{
    class Employee_Details
    {
        public int Emp_id;
        public string Emp_Name;
        public double Gross_Salary;
        public double Tax_Deduction = 0.1;
        public double Net_Salary;

        public  Employee_Details(int eid, string ename, double grosssalary)
        {
            Emp_id = eid;
            Emp_Name = ename;
            Gross_Salary = grosssalary;
        }

        void calculate_salary()
        {
            if (Gross_Salary >= 40000) { 
            Net_Salary = Gross_Salary - (Tax_Deduction * Gross_Salary);
                Console.WriteLine("Your Salary is : {0}",Net_Salary);
            }
            else
            {
                Console.WriteLine("Your Salary is : {0}", Gross_Salary);
            }
        }
        public void Employee_Salary()
        {
            Console.WriteLine("Employee Id is : {0}", Emp_id);
            Console.WriteLine("Employee name is : {0}", Emp_Name);
            Console.WriteLine("Employee Gross Salary is : {0}", Gross_Salary);
            Console.WriteLine("Employee Tax is : {0}", Tax_Deduction);
            this.calculate_salary();
        }

        static void Main(string[] args)
        {
            Employee_Details sal = new Employee_Details(1, "sappo", 44000);
            sal.Employee_Salary();
            Console.ReadKey();
        }
        ~Employee_Details()
        {

        }

    }
    
    
}
