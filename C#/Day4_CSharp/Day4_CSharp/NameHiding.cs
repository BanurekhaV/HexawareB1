using System;

namespace Day4_CSharp
{
    internal class ParentClass
    {
        public int datavalue;

        //constructor - parameterized
        public ParentClass(int datavalue) 
        {
            this.datavalue = datavalue;  
        }
        public void methodHiding()
        {
            Console.WriteLine( "Parents Method..." + " " + datavalue);
        }
    }

    class ChildClass : ParentClass
    {
        new int datavalue;   // this hides the datamember in Parentclass

        public ChildClass(int a) : base(a)
        {
            datavalue = a;
        }

        public ChildClass(int a, int b) : base(b)
        {
            datavalue = a;
        }
        public new void methodHiding()   //method hiding from parentclass
        {
            Console.WriteLine("Childs Method..." + " " + datavalue);
        }

        public void Show()
        {
            Console.WriteLine("data values in Parent Class : " + base.datavalue);
            Console.WriteLine("data values in Child Class : " + datavalue);
            Console.WriteLine("--------------------");
            base.methodHiding();
            methodHiding();
        }
    }

    class DriverClass
    {
        static void Main(string[] args)
        {
            ChildClass c = new ChildClass(500);   //one parameter constructor
            c.Show();

            ChildClass c2 = new ChildClass(5,10); //two parameter constructor
            c2.Show();
            Console.Read();
        }
    }
}
