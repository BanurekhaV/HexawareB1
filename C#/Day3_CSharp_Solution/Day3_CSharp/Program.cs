using System.Text;

namespace Day3_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            Console.WriteLine(str.GetHashCode());
            str = "Hello World";
            Console.WriteLine(str.GetHashCode());

            string str2 = str;
            Console.WriteLine(str2.GetHashCode() + " " + str2);
            Console.WriteLine("++++++++++++++++++");
            StringBuilder sb = new StringBuilder("hello");
            Console.WriteLine(sb.ToString() + " " + sb.GetHashCode());
            sb.Append(" World");
            Console.WriteLine(sb.ToString() + " " + sb.GetHashCode());
            Console.WriteLine("=======================Arrays=====================");            
            ArraysEg.SingleDimension();
            Console.WriteLine("----------------------");
            ArraysEg.DoubleDimension();
            ArraysEg.JaggedDimension();
            Console.Read();
        }
    }
}
