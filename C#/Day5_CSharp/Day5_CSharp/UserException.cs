using System;


namespace Day5_CSharp
{
    public class VotingException : Exception
    {
        public VotingException(string msg) : base(msg) { }
    }

    class Vote
    {
        int age;

        public void AcceptAge()
        {
            Console.WriteLine("enter Your Age  : ");
            age = Convert.ToInt32(Console.ReadLine());
            if(age<18)
            {
                throw (new VotingException("Age should be greater than 18 to Vote.."));
            }
            else
                Console.WriteLine("Thanks for Voting..");
        }
    }
    internal class UserException
    {
        static void Main()
        {
            //Vote vote = new Vote();
            //try
            //{
            //    vote.AcceptAge();
            //}
            //catch (VotingException ve)
            //{
            //    Console.WriteLine(ve.Message);
            //}
          //  NestedTrycatch.TestNestedTry();
          OverFlowExample.CheckOverFlow();
            Console.WriteLine("------------------------");
            Console.WriteLine(OverFlowExample.UncheckOverFlow());  
            Console.Read();
        }
    }

    class NestedTrycatch
    {
        public static void TestNestedTry()
        {
            int[] num = { 16, 17, 8, 24, 5 };
            int[] divisors = { 2, 0, 5 };

            try
            {
                for(int i = 0;i<num.Length;i++)
                {
                    try
                    {
                        Console.WriteLine($"Number : {num[i]}, Divisor : {divisors[i]}");
                        Console.WriteLine($"Quotient : {num[i]} / {divisors[i]}");
                        Console.WriteLine(num[i] / divisors[i]);
                     }
                    catch(DivideByZeroException e)
                    {
                        Console.WriteLine("Division by zero at inner try..");
                    }
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Outer Try Error..");
            }
        }
    }

    class OverFlowExample
    {
        //max value of an integer = 2147483647

        static int maxInt = 2147483647;

        //checked expression
        public static int CheckOverFlow()
        {
            int x = 0;
            try
            {
                //the below code will raise an exception
                x = checked(maxInt + 10);
            }
            catch (OverflowException e) 
            {
                //information about the error
                Console.WriteLine("Checked : " + e);
            }

            return x;
        }
        
        public static int UncheckOverFlow()
        {
            int x = 0;
            try
            {
                x = maxInt + 10;
            }
            catch(OverflowException e)
            {
                Console.WriteLine("UnChecked : " + e);
            }
            //overflow is supressed ans the sum of maxint  + 10 leads to negative value (the range of an integer)
            return x;

        }
    }
}
