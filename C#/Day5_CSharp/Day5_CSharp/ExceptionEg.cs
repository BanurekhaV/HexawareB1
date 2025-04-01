using System;
using System.Linq.Expressions;

namespace Day5_CSharp
{
    internal class ExceptionEg
    {
        static void Main()
        {
            int a, b, c;
            try
            {
                Console.WriteLine("Enter 2 numbers : ");
                a = int.Parse(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;
                int[] arr = { 1, 2, 3, 4, 5 };
                Console.WriteLine(arr[8]);
                Console.WriteLine(c);
            }

            catch (DivideByZeroException de)
            {
                //Console.WriteLine(de.Source);
                //Console.WriteLine(de.Message);
                Console.WriteLine("Dividing a number with 0 is not allowed. Please give valid denominator");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Please enter only numbers");
                Console.WriteLine(fe.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //Console.WriteLine("OOps ! something went wrong.. try later");
            }
            finally
            {
                Console.WriteLine("Reached Finally...");
            }
            Console.Read();           
        }
    }
}
