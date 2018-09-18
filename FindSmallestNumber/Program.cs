using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSmallestNumber
{
    //Determines the two smallest number in an array
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Determines the two smallest number in an array and the Mode of the array");
            FindSmallestNumbers();

        }

        static void FindSmallestNumbers()
        {
            Console.WriteLine("Will find the samllest in the array:  9, 4, 5, 3, 2, 7, 6, 1, 8, 9" );
           int[] numbers = new int[] { 9, 4, 5, 3, 2, 7, 6, 1, 8 };

        var orderedList = numbers.OrderBy(i => i).ToList();

        Console.WriteLine("Smallest Numbers in array are {0} and {1}", orderedList[0], orderedList[1]);

            var list = numbers.GroupBy(x => x)
               .Select(group => new
               {
                   number = group.Key,
                   mode = group.Count()
               })
           .OrderByDescending(n => n.mode);

            Console.WriteLine("Mode Number in array is {0}", list.FirstOrDefault().number);
            Console.ReadKey();
        }
    }
}
