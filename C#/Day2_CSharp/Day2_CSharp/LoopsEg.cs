using System;


namespace Day2_CSharp
{
    internal class LoopsEg
    {
        public void WhileLoop()
        {
            int i = 1;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void DoWhileLoop()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }

        public void ForLoop()
        {
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                    //break;
                    continue;
                total += i;
            }
            Console.WriteLine("The Total is {0}", total);
        }

        public int GetNum()
        {
            Console.WriteLine("This is a start of function");
            return 10;
            Console.WriteLine("This is a end of function");
        }
    }
}
