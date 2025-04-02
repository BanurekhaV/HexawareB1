using System;

namespace Day6_CSharp
{
    
    internal class IndexersEg2
    {
        //array field
        private string[] words = new string[3];

        //indexer to set or get values to or from the elements of the words array

        public string this[int flag]
        {
            get
            {
                return words[flag];
            }
            set
            {
                words[flag] = value;
            }
        }

        static void Main()
        {
            IndexersEg2 iEg2 = new IndexersEg2();
            iEg2[0] = "How";
            iEg2[1] = "are";
            iEg2[2] = "you";
            Console.WriteLine(iEg2[0] + " " + iEg2[1] + " " + iEg2[2]);
            Console.Read();
        }
    }

}
