namespace Day6_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //label
            goto Hexaware;
            Console.WriteLine("This is Line 1...");
            Console.WriteLine("This is Line 2 ..");

        Hexaware:
            Console.WriteLine("Hexaware welcomes you all on Board ...");

            goto label1;

                Console.WriteLine("You have reached Label 1 ..");
            Console.WriteLine("See You !!");

            label1:

            Console.WriteLine("Bye...");

            doAgain:
            Console.WriteLine("Enter a number less than 10.");
            int num = int.Parse(Console.ReadLine());
            if(num >=10)
            {
                Console.WriteLine("Number should be less than 10 only .");
                goto doAgain;
            }
            Console.WriteLine(num +  " is less than 10");
            Console.Read();
        }
    }
}
