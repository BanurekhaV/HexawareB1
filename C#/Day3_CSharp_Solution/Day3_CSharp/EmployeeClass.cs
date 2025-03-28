using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_CSharp
{
    class EmployeeClass
    {
        static int Empid = 100;
        string Empname;
        double Salary;

        //constructor
        //1.
        internal EmployeeClass()
        {
            Console.WriteLine("Hi Getting Constructed...");
        }

        //2. 
        public EmployeeClass(int empid)
        {
            Empid = empid;
            Console.WriteLine(Empid);
        }
        public void GetEmp()
        {
            Console.WriteLine("Enter Empid, name and Salary :");
            Empid = Convert.ToInt32(Console.ReadLine());
            Empname = Console.ReadLine();
            Salary = Convert.ToDouble(Console.ReadLine());
        
        }

        public void ShowEmp()
        {
            Console.WriteLine($"Employee id : {Empid}, Empname : {Empname}, and Salary :{Salary}");
        }

        public static void ChangeEmpid()
        {
            Empid++;
            Console.WriteLine("The Changed Empid is : {0}", Empid);
        }
    }

    class TesterClass 
    {
        public static void Main()
        {
            EmployeeClass emp = new EmployeeClass();
           
            emp.ShowEmp();

            emp.GetEmp();
            emp.ShowEmp();

            EmployeeClass.ChangeEmpid();
            emp.ShowEmp();
            Console.WriteLine("------------------------");
            EmployeeClass emp2 = new EmployeeClass(101);
            emp2.ShowEmp();
            Console.Read();
        }

    }
}
