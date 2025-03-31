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
            Console.WriteLine("--------Operator Overloading----------");

            Distance d1, d2, d3;
            d1 = new Distance();
            d1.dist = 25;
            d2= new Distance();
            d2.dist = 30;
            d3 = d1 + d2;
            Console.WriteLine("The total distanec is {0}", d3.dist);
           // d3++;
            Console.WriteLine("The incremented distance is {0}", d3.dist);
            Console.Read();
        }
    }

    class Distance
    {
        public int dist;
        
        //operator overloading
        public static Distance operator +(Distance a, Distance b)
        {
            Distance temp= new Distance();
            temp.dist= a.dist + b.dist;
            return temp;
        }

    }
}
