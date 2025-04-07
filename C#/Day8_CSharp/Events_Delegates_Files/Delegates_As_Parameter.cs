using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Delegates_Files
{
    public delegate int Arithmetic(int x, int y);
    internal class Delegates_As_Parameter
    {
        static void Main()
        {
            DoOperation(10, 2, Multiply);
            DoOperation(10,2, Divide);
            Console.Read();
        }

        //function that takes delegate as a parameter
        static void DoOperation(int x, int y, Arithmetic Adel)
        {
            int z = Adel(x,y);
            Console.WriteLine(z);
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)         
        {
            return x / y;
        }   
    }
}
