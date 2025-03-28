using System;

namespace Day3_CSharp
{
    internal class ArraysEg
    {
        public static void SingleDimension()
        {
            int[] data = new int[] { 42, 6, 8, 35, 3 };
            Console.WriteLine(data.Length + " " + data.Rank);
            Console.WriteLine("------Before Sort------");
            foreach (int i in data)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------After Sort-------");
            Array.Sort(data);
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
        }

        public static void DoubleDimension()
        {
            int[,] myarray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(myarray[1, 1]); //prints 5

            myarray[0, 0] = 1;
            myarray[0, 1] = 2;

            //we use iterations for assigning and retrieving the values of an array
            // for(int i = 0;i < 2;i++)
            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    Console.Write(myarray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void JaggedDimension()
        {
            //1. declare an jagged array of 2 rows
            int[][] myjagg = new int[2][]; //first square bracket refers to the row and the second one refers to the coulns of that row

            //2. let us set the size of each row
            myjagg[0] = new int[3];
            myjagg[1] = new int[2];

            //3. let us initialize the data
            myjagg[0][0] = 2;
            myjagg[0][1] = 4;
            myjagg[0][2] = 6;

            myjagg[1][0] = 1;
            myjagg[1][1] = 3;

            //3.1 another way to initialize the elements
            int[][] jag2 =
            {
                new int[]{5,10,15,20 },
                new int[]{25,30},
                new int[]{35,40,45 }
            };

            //4. Let us display the values
            for (int i = 0; i < jag2.Length; i++)
            {
                Console.WriteLine("Number of Elements at Row : " + i + " Is " + jag2[i].Length);

                //inner loop
                for (int j = 0; j < jag2[i].Length; j++)
                {
                    Console.Write(jag2[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}