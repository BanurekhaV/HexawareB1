using System;

namespace Day2_CSharp
{
    internal class OtherTypes
    {
        
        public static void Implicit_Types()
        {
            int x;  // only declaration
            x = 50; // assignment later
            int y = 5; //decl and assignment together is optional

            //implicit types
            var v = 4;  //decl and assign at the same time is a compulsion
                           //once assigned cannot change the type

            //dynamic types
            dynamic d; //just decl.

            d = 'a';
            d = false;
            d = "Abc";
           // d = 25.55;
            Console.WriteLine(d);

            //Anonymous Types
            var atype = new
            {
                data1 = "CSharp",
                data2 = 5,
                data3 = true
            };
            Console.WriteLine($"Anonymous Type {atype}");
            Console.WriteLine(atype.data1 + " " +atype.data2);
        }
    }
}
