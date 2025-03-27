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

            CheckGradeSwitch();
        }
        public static void CheckGradeSwitch()
        {
            char grade;
            Console.WriteLine("Enter Grade :");
            grade= Convert.ToChar(Console.ReadLine());

            switch (grade)
            {
                case 'O':
                case 'o':
                    Console.WriteLine( "Outstanding");
                    break;
                case 'E':
                case 'e':
                    Console.WriteLine("Excellent");
                    break;
                case 'A':
                case 'a':
                    Console.WriteLine("Very Good");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Fair");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;                       
            }
            /*multiple switch
            int intval1=3;
            string strval1="hi";
            bool boolval1=true;
           switch((intval1,strval1,boolval1))
            {
                case (1, "Hello", false):
                    break;
                case (2, "World", false):
                    break;

            }*/
        }
    }
}
