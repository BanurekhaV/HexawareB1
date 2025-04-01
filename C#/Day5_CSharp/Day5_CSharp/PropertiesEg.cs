using System;

namespace Day5_CSharp
{
    class Student
    {
        private string Code = "N.A";
        private string Name = "Unknown";
        private int age = 10;

        //auto implemented properties
        public float Marks { get; }
        public string Class { get; private set; } = "10th";
        public string Mobile { get; protected set; }

        //for all the above / some of the above fields we can declare properties
        public string _Code
        {
            get { return Code; }
            set { Code = value; }
        }

        public string StudentName
        {
            get { return Name; }
            set { Name = value; }
        }

        //only read property
        public int Age
        {
            get { return age; }
        }
    }
    internal class PropertiesEg : Student
    {
        public static void Main()
        {
            //create a student object
            Student student = new Student();
            Console.WriteLine($"Students Name {student.StudentName}, Code : {student._Code} and Age is {student.Age}");  // call get accessor
           
            student.StudentName = "Hajira";  // will call the set accessor
            student._Code = "1003";
           // student.Age = 20; cannot set as set accessor is not implemented

            Console.WriteLine($"Students Name {student.StudentName}, Code : {student._Code} and Age is {student.Age}");

            Console.WriteLine(student.Class);
           // student.Mobile = "tfgyihujk"; 

            PropertiesEg peg = new PropertiesEg();
            peg.Mobile = "556790";
            Console.Read();
        }
    }
}
