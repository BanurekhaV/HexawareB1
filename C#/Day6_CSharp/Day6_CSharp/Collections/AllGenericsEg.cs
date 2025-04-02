using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_CSharp.Collections
{
    internal class AllGenericsEg<T>   //where T : struct
    {
        //generic field

        private T genericMemberVariable;

        //generic property
        public T genericProperty { get; set; }

        //generic constructor
        public AllGenericsEg(T value)
        {
            this.genericMemberVariable = value;
        }

        //generic method

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter Type : {0}, Parameter Value : {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return Type : {0} , Return Value : {1}", typeof(T).ToString(), genericMemberVariable);
            return genericMemberVariable;
        }
        
    }

    class TestGenerics
    {
        static void Main()
        {
            //let us create an integer instance
            AllGenericsEg<int> intGeneric = new AllGenericsEg<int>(10);

            int retval = intGeneric.genericMethod(200);
            Console.WriteLine(retval);

            Console.WriteLine("-----------------------");

            AllGenericsEg<string> strGeneric = new AllGenericsEg<string>("Hi Generics..");
            Console.WriteLine(strGeneric.genericMethod("Class on generics.."));
            strGeneric.genericProperty = "hi";
            Console.Read();
        }
    }
}
