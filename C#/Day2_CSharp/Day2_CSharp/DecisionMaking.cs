using System;


namespace Day2_CSharp
{
    internal class DecisionMaking
    {
        public static void CheckGrade()
        {
            char grade;
            Console.WriteLine("Enter the grade : O/E/A/B");
            grade = Convert.ToChar(Console.ReadLine());
            if (grade == 'O' || grade == 'o')
                Console.WriteLine("Outstanding");
            else if (grade == 'E')
                Console.WriteLine("Excellent");
            else if (grade == 'A')
                Console.WriteLine("VeryGood");
            else if (grade == 'B')
                Console.WriteLine("Fair");
            else Console.WriteLine("Invalid Grade");
        }
    }
}
