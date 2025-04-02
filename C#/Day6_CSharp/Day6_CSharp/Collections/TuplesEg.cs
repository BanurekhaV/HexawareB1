using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Day6_CSharp.Collections
{
    internal class TuplesEg
    {
        static void Main()
        {
            var values = new List<double> { 10, 20, 30, 40, 50 };

            //option 1 way to access return items
            //var result = Calculate(values);

            //Console.WriteLine($"There are {result.count} items and their Sum is {result.sum}");
            //Console.WriteLine($"Maximum of the list {result.max}");
           
            //2. accessing by naming the result values
            var(countresult,sumresult,maxresult)=Calculate(values);

            Console.WriteLine($"There are {countresult} elements, and their Sum is {sumresult} " +
                $"and the maximum values is {maxresult}");
            
            Console.Read();
        }

        static (int count, double sum, double max) Calculate(List<double> values)
        {
            int count = 0;
            double sum = 0.0;
            double max = values.Max();
            foreach (var v in values)
            {
                count++;
                sum += v;
            }
           
            return (count, sum, max);
        }
    }

}
