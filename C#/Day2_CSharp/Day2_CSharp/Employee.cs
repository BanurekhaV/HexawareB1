using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_CSharp
{
    internal class Employee
    {
        //data members / fields / properties
         int Empid;
        string EmpName;
        float Salary;
        string gender;
        DateTime HireDate;

        //member functions
        public void GetEmpDetails()
        {
            Console.WriteLine("Enter Empid:");
            Empid = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayEmpDetails()
        {
            Console.WriteLine(Empid);   

        }
    }
}
