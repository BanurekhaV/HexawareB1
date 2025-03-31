using System;


namespace Day4_CSharp
{
    internal class OverLoadEg
    {
        public static void Swap(int number1, int number2)   
        {
            number1 = number1 + number2;    
            number2 = number1 - number2;     
            number1 = number1 - number2;

            Console.WriteLine("Swapping of Integers number1 = " + number1 + " number 2 = " + number2);

        }

        //method overload
        public static void Swap(char character1, char character2)
        {
            char temp = ' ';
            temp = character1;
            character1 = character2;
            character2 = temp;

            Console.WriteLine("Swapping of Characters character1 = " + character1 + " charcater 2 = " + character2);
        }

        static void Main()
        {
            Swap(5, 10);  //compiler resolves call   line no. 9
            Swap('a', 'b');  // line no. 20
            Console.Read();
        }
    }
}
