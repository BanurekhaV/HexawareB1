using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Delegates_Files
{
    internal class MulticastDelegates
    {
        public delegate void MultiDelegate();

        public static void Method1()
        {
            Console.WriteLine(" Method 1 Invoked..");
        }

        public static void Method2()
        {
            Console.WriteLine(" Method 2 Invoked..");
        }

        public static void Method3()
        {
            Console.WriteLine(" Method 3 Invoked..");
        }
        static void Main()
        {
            //multicasting option 1
            //MultiDelegate d1, d2, d3, d4;
            //d1= new MultiDelegate(Method1);
            //d2= new MultiDelegate(Method2);
            //d3= new MultiDelegate(Method3);

            //d4 = d2 + d1 + d3; //multicasting
            //d4();

            //d4 = d2 + d1 - d3; //removing one of the multicasted method
            //d4();

            MultiDelegate M1 = new MultiDelegate(Method1);
            M1+= Method2;
            M1+= Method3;

            M1();
            Console.WriteLine("-------");
            M1 -= Method2;
            M1();
            Console.Read();

        }
    }
}
