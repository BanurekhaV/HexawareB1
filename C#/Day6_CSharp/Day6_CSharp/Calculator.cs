using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_CSharp
{
    public class Calculator
    {
        public int Add(int x, int y)
        {

        return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

    }

    class CalculatorClient
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Addition : " + " "  + calculator.Add(1, 2));
            Console.WriteLine("Subtraction : " + " " + calculator.Subtract(3,2));
            Console.WriteLine("Multiplication : " + " " + calculator.Multiply(2,3));
            Console.WriteLine("Division : "+ " " + calculator.Divide(3,2));
            Console.Read();
        }
    }

    public static class CalculatorAddOn
    {
        public static int Multiply(this Calculator calcobj,int x, int y)
        {
            return x * y;
        }

        public static int Divide(this Calculator calccobj, int x, int y)
        {
            return x / y;
        }
    }
}
