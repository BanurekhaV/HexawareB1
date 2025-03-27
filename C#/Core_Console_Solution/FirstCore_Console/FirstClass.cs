namespace FirstCore_Console
{
    
    internal class FirstClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("This stays in the same line..");
            FirstClass firstClass = new FirstClass();
            FirstClass fc = new FirstClass();
           // firstClass.AcceptDetails(); // calling instance function thru an object
            AcceptDetails();   //calling static functions within the class by its name directly

            //calling a static function which is in another class
            SecondClass.DisplayDetails();
            Console.ReadKey();
        }

        public static void AcceptDetails()
        {
            string? userFName, userLName;
            Console.WriteLine("Enter Your Name First and Last Names :");
            userFName = Console.ReadLine();
            userLName = Console.ReadLine();
            Console.WriteLine("Your Full Name is : " + userFName + " " + userLName);  //Concatenation
            Console.WriteLine("Your Full Name is : {0} {1}", userFName,userLName); //Placeholder
            Console.WriteLine($"Your Full name is {userFName} {userLName}"); //string interpolation
        }

        public int Add(int x, int y)   // instance function
        {
            return x + y;
        }
    }

    class SecondClass
    {
        public static void DisplayDetails()
        {
            Console.WriteLine("Hi ! I am DisplayDetails of Second Class");
        }
    }
}
