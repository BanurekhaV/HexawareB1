using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Delegates_Files
{
    internal class AnonymousMethods_n_DelegateTypes
    {
        delegate void Print(int v);

        static void Main()
        {
            int i = 100;

            Print p = delegate (int x) //anonymous method
            {
                x += i;
                Console.WriteLine("We are Inside the Anonymous Method {0}", x);
            };
            p(10);

            //eg 2

            int[] numbers = {1,2,3,4,5,6,7,8,9,10};
            int[] evennos = Array.FindAll(numbers, delegate (int n)
            {
                return n % 2 == 0;
            });

            Console.WriteLine("=======Even Nos.========");
            foreach(int n in evennos) Console.WriteLine(n);

            Console.WriteLine("-----------Predicate----------");

            //Predicate Delegate with Anonymous method
            Predicate<string> chkUpper = delegate (string s){return s.Equals(s.ToUpper());};
            bool result = chkUpper("HELLO WORLD");
            Console.WriteLine(result);

            //Predicate Delegate with Lambda expression
            Predicate<string> isUpper = s => s.Equals(s.ToUpper());
            bool answer = isUpper("hello world");
            Console.WriteLine(answer);

            //Action Delegate with Anonymous Method
            Console.WriteLine("---------Action Delegate----------");
            Action<int> DisplayActionDelegate = delegate (int v)
            {
                Console.WriteLine(v+5);
            };

            DisplayActionDelegate(20);

            //Action Delegate with Lambda
            Action<int>PrintActionDel = v => Console.WriteLine(v+10);

            PrintActionDel(50);

            //Function Delegate with Anonymous Method
            Console.WriteLine("======Function Delegates=======");
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1,100);
            };

            int getNumber = getRandomNumber();
            Console.WriteLine(getNumber);

            //Function Delegates with Lambda
           Func<int> RandomNumberDel = () => new Random().Next(1, 100);
            Console.WriteLine(RandomNumberDel());
            
            //calling again an anonymous method using the delegate
            p(250);

            //another example of Func Delegate with lambda
            Func<int, int, int> Total = (a, b) => a + b;
            Console.WriteLine(Total(10,20));
            Console.Read();
        }
    }
}
