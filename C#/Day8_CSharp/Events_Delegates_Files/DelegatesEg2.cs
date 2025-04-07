using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Delegates_Files
{
    delegate int NumberChanger(int n);
    internal class DelegatesEg2
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultiplyNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        static void Main()
        {
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultiplyNum);
            nc1 += MultiplyNum;
            nc1(25);
            Console.WriteLine("Value of Num after addition {0}", getNum());

            nc2(5);
            Console.WriteLine("Value of Num after multiplication {0}", getNum());
            Console.Read();
        }
    }
}
