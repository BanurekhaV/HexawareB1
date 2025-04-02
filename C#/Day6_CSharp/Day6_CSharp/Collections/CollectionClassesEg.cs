using System;
using System.Collections;

namespace Day6_CSharp.Collections
{
    internal class CollectionClassesEg
    {
        public static void Main()
        {
            //ArrayListEg();
           // HashtableEg();
            StackEg();
            Console.Read();
        }
        public static void ArrayListEg()
        {
            //initializing the array with values
            ArrayList arraylst = new ArrayList();
            arraylst.Add(6);
            arraylst.Add('g');
            arraylst.Add(true);
            arraylst.Add("Hello");
            arraylst.Add(24.54f);
            arraylst.Add(567.85);

            foreach(var item in arraylst)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count = " + arraylst.Count);
            Console.WriteLine("Cpacity = " + arraylst.Capacity);

            ArrayList al2= new ArrayList();
            al2.Add(9);
            al2.Add(3);
            al2.Add(5);
            al2.Add(2);

            arraylst.AddRange(al2);

            Console.WriteLine("=========After adding another collection========");
            foreach (var item in arraylst)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count = " + arraylst.Count);
            Console.WriteLine("Cpacity = " + arraylst.Capacity);
            arraylst.Remove('g');

          //  arraylst.Sort();
          al2.Sort();

            foreach (var item in al2)
            {
                Console.WriteLine(item);
            }
        }

        public static void HashtableEg()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(3, "Harini");  //key and value can be of different data types
            hashtable.Add(8, "Keerthieswaran");
            hashtable.Add(1, "Kuvala");
            hashtable.Add(5, null);  //values can be null but not key
            hashtable.Add(4, "Harini");  //values can be duplicates but not key

            foreach (var item in hashtable)
            {
                Console.WriteLine(item);               
            }
        }

        public static void StackEg()
        { 
            Stack stack = new Stack();
            stack.Push(3);
            stack.Push("Hi");
            stack.Push('A');
            stack.Push(10);

            foreach(object o in stack)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine(stack.Count);

            stack.Pop();

            Console.WriteLine(stack.Peek());

            foreach (object o in stack)
            {
                Console.WriteLine(o);
            }

        }
    }
}
