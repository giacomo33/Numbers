using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    //Caluculates sum of the first n numbers using LINQ
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Application will sum of the first n numbers");
            Sum();

        }

        static void Sum()
        {
            Console.WriteLine("Enter a Natural Number: ");
            string textEntered = Console.ReadLine();
            long numberEntered = textEntered.ReadOnlyNumbers();

          long sum= Helper.Sum(numberEntered);
            long sumSq = Helper.SumSquared(numberEntered);
            Console.WriteLine("Sum of {0} Numbers is {1}", numberEntered, sum);
            Console.WriteLine("Sum of {0} Numbers Squared is {1}", numberEntered, sumSq);

            Console.WriteLine("Enter another number Y or N");
            ConsoleKeyInfo selection = Console.ReadKey();
            if (selection.Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                Sum();
            }
            else if (selection.Key == ConsoleKey.N)
                return;

        }
    }
}
