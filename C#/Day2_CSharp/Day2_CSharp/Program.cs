namespace Day2_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program = new Program();
            program.main();
            program.Func1();
            program.Func2();
            Console.Read();
        }

       public void main()
        {
            Console.WriteLine( "Minimum Values of an Int is {0}", int.MinValue);
            Console.WriteLine( "Maximum of int is {0}", int.MaxValue);
        }
        public void Func1()
        {
            int num = 11;
            //bool b;
            //if (num == 10)
            //{
            //    b = true;
            //}
            //else
            //{
            //    b = false;
            //}
            //the above can be replaced with ternary operator
            bool b = num == 10 ? true : false;

            Console.WriteLine("Is Num == 10 ? {0}", b);
        }
        public void Func2()
        {
            //type conversions
            int i = 100;
            float f;
            f = i;      //implicit conversion
            Console.WriteLine(f);

            f = 125.45f;
            i = (int)f;  // explicit conversion by typecasting
            Console.WriteLine($"The typecasted values is {i}");

            i = Convert.ToInt32(f); //explicit conversion using function
            Console.WriteLine($"The Converted values is {i}");
        }

    }
}
