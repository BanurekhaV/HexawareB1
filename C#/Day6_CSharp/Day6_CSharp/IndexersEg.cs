using System;


namespace Day6_CSharp
{
    public class Employee
    {
        //declare properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }

        //constructor
        public Employee(int Id, string Name, string Job, double Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Job = Job;
            this.Salary = Salary;
        }

        //declare an indexer with interger as parameter to define position
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return Id;
                else if (index == 1)
                    return Name;
                else if (index == 2)
                    return Job;
                else if (index == 3)
                    return Salary;
                else
                    return null;
            }
            set
            {
                if (index == 0)
                    Id = Convert.ToInt32(value);
                else if (index == 1)
                    Name = value.ToString();
                else if (index == 2)
                    Job = value.ToString();
                else if (index == 3)
                    Salary = Convert.ToDouble(value);
            }
        }

        //overloading an indexer 

        public object this[string s]
        {
            get
            {
                if (s == "Id")
                    return Id;
                else if (s == "Name")
                    return Name;
                else if (s == "Job")
                    return Job;
                else if (s == "Salary")
                    return Salary;
                else
                    return null;
            }
            set
            {
                if (s == "Id")
                    Id = Convert.ToInt32(value);
                else if (s == "Name")
                    Name = value.ToString();
                else if (s == "Job")
                    Job = value.ToString();
                else if (s == "Salary")
                    Salary = Convert.ToDouble(value);
            }
        }

        //let us override the tostring() of the object class
        public override string ToString()
        {
            return "Employee :" + Name + " works as :  " + Job + " and Earns a Salary of : " + Salary;
        }
    }
    internal class IndexersEg
    {
        public static void Main()
        {
            //create employee instance
            Employee emp = new Employee(101, "Makeshwar","Software programmer",45000);

            //accessing employee properties using index, i.e. position
            Console.WriteLine("EID = " + emp[0]);
            Console.WriteLine("Name = " + emp[1]);
            Console.WriteLine("Job = " + emp[2]);
            Console.WriteLine("Salary = " + emp[3]);

            Console.WriteLine("==============Setting Values============");
            emp[1] = "Nithyasree";  
            emp[2] = "Tester";

            Console.WriteLine("EID = " + emp[0]);
            Console.WriteLine("Name = " + emp[1]);
            Console.WriteLine("Job = " + emp[2]);
            Console.WriteLine("Salary = " + emp[3]);

            //accessing employee properties using s, i.e. property names

            Console.WriteLine("==========Overloaded Indexer=========");

            emp["ID"] = 201;
            emp["SALARY"] = 50000;

            Console.WriteLine("EID = " + emp["Id"]);
            Console.WriteLine("Name = " + emp["Name"]);
            Console.WriteLine("Job = " + emp["Job"]);
            Console.WriteLine("Salary = " + emp["Salary"]);
            Console.Read();
        }
    }
}
