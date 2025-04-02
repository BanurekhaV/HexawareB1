using System;
using System.Collections;
using System.Collections.Generic;

namespace Day6_CSharp.Collections
{
    internal class GenericsEG
    {
        public static void ListEg()
        {
            List<int> list = new List<int>();
            list.Add('A');
            list.Add(34);
            list.Add(12);

            list.Sort();

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("User Defined List Collection-----");
            List<Employee> emplist= new List<Employee>();
            emplist.Add(new Employee(200, "Rakshith", "Operations manager", 40000));
            emplist.Add(new Employee(210, "Rohith", "Sales manager", 40000));
            emplist.Add(new Employee(203, "Hrithik", "IT manager", 40000));

            //foreach(Employee e in emplist)
            //{
            //    Console.WriteLine(e.Id + "  " +  e.Name);
            //}
            foreach (Employee emp in emplist) 
            { 
                Console.WriteLine(emp.ToString());
            }

        }

        public static void DictionaryEg()
        {
            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(1, "Red");
            dict.Add(2, "Blue");
            dict.Add(3, "Green");
            dict.Add(4, "Yellow");

            foreach(int i in dict.Keys)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            foreach(string s in dict.Values)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            foreach(KeyValuePair<int,string> kvp in dict)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine(kvp.Value);
            }

            Console.WriteLine("enter the key to retrive color : ");
            int k = Convert.ToInt32(Console.ReadLine());
            if (dict.ContainsKey(k))
            {
                Console.Write(k + " represents " + dict[k]);
            }
            else
            {
                Console.WriteLine("Key not found...");
            }
        }

        static void Main()
        {
           // ListEg();
            DictionaryEg();
            Console.Read();
        }
    }
}
