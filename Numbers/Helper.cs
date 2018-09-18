
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sum
{
    public static class Helper
    {
        static IEnumerable<long> CalculatePrimeNumbers(long number)
        {
            return number.GetPrimeNumbers();
        }

        public static IEnumerable<long> GetPrimeNumbers(this long number)
        {
            long originalNumber = number;
            do
            {
                if (IsPrime(number))
                    yield return number;

                number--;
            }
            while (number > 1);
        }

        public static bool IsPrime(long Number)
        {
            IList<long> basicPrimeNumbers = new List<long>() { 2, 3, 5, 7 };
            if (basicPrimeNumbers.Contains(Number))
                return true;

            return ExtendedEnumerableRange.Int64(2, (long)Math.Sqrt(Number))
                .All(n => Number % n != 0);
        }

        public static long SumPrimeNumbersBelow(long number)
        {
            return number.GetPrimeNumbers().Sum();
        }

        public static long Sum(long N)
        {
           return ExtendedEnumerableRange.Int64(1, N).Sum();
        }

        public static long SumSquared(long N)
        {
            return ExtendedEnumerableRange.Int64(1, N).Sum(n => n * n);
        }

        public static long ReadOnlyNumbers(this string line) =>
            Regex.Split(line, @"\D+")
              .Aggregate(0L, (x, y) =>
              long.Parse($"{x}{y}"));
    }
}
