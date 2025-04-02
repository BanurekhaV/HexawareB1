using System;


namespace Day6_CSharp
{
    public static class StringExtMethod
    {
        public static int GetWordcount(this string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                //split the string by a space
                string[] strarray = s.Split(' ');
                return strarray.Count();
            }
            else
            {
                return 0;
            }
        }
    }

    class StringExtensionTester
    {
        static void Main()
        {
            string str = "Welcome to CSharp Extension Methods";
            int noof_words = str.GetWordcount();
            Console.WriteLine("The String : " +  str);
            Console.WriteLine("Word Count in the string : " + noof_words);
            Console.Read();
        }
    }
}
