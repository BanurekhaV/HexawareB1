using System;

namespace Day2_CSharp
{
    enum cities {Agra=3,Ahmedabad=5,Bangalore=1,Chennai=2,Delhi=4,Hyderabad=7, Mumbai=6}
   class Student
    {
        public int marks1;
        public int marks2;
    }
    internal class Struct_EnumEg
    {
        public static void Enum_Operations()
        {
            //get the values and then its corresponding Name
            foreach(int x in Enum.GetValues(typeof(cities)))
            {
                if(x==1)
                    Console.WriteLine(Enum.GetName(typeof(cities),x) + " " + "Is a Garden City");
                else if(x==2)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + " " + "Is a Temple City");
                else if(x==6)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + " " + "Is a Finance City");
            }

            //Get the Names in iteration
            foreach(var v in Enum.GetNames(typeof(cities)))
            {
                Console.WriteLine(v);
            }
        }
        static void Main()
        {
            Student stud1 = new Student();
            stud1.marks1 = 95;
            stud1.marks2 = 86;
            Console.WriteLine(stud1.marks1 + stud1.marks2);

            Student stud2 = stud1;

            Console.WriteLine(stud2.marks1 + stud2.marks2);
            stud1.marks1 = 100;
            Console.WriteLine("--------After Reassigning--------");

            Console.WriteLine(stud1.marks1 + stud1.marks2);
            Console.WriteLine(stud2.marks1 + stud2.marks2);
            Console.WriteLine( "*******************");
            Enum_Operations();
            Console.Read();

        }
    }
}
