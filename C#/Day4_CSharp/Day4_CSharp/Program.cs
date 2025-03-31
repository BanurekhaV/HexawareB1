using System.Transactions;

namespace Day4_CSharp
{
    class Student
    {
        int RollNo;
        string ? Name;
        string ? Class;

        public void GetData()
        {
            Console.WriteLine("Enter Roll no :");
            RollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Class :");
            Class = Console.ReadLine();
        }

        public void PutData()
        {
            Console.WriteLine($"Name of the Student : {Name}, RollNo :{RollNo} and Class :{Class}");
        }
    }

    class Marks : Student
    {
        protected int[] marks = new int[5];

        public void GetMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Enter Subject {0} Marks : ", i + 1);
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PutMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Subject {0} Marks {1} :", i + 1, marks[i]);               
            }
        }
    }

    class Results : Marks
    {
        int TotalMarks = 0;

        public void GetResults()
        {
            for (int i = 0; i < marks.Length; i++)
            {
               TotalMarks = TotalMarks + marks[i];
            }
        }

        public void PutResults()
        {
            Console.WriteLine(  "=========== Results =============");
            PutData();
            PutMarks();
            Console.WriteLine("Total Marks = " + TotalMarks);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Results results = new Results();
            results.GetData();
            results.GetMarks();
            results.GetResults();
            results.PutResults();
            Console.Read(); 
        }
    }
}
