namespace TypeFundamentals2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NumberManager
    {
        public static List<int> GeneratePrimeNumbersList(int n)
        {
            List<int> primes = new List<int> { 2 };
            int nextPrime = 3;
            while (primes.Count < n)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;
                for (int i = 0; primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }
            return primes;
        }

        public static double GetIntegerPartOfElementsSum(List<int> list)
        {
            var valuesAndIndexes = list.Zip(list.Select(index => list.IndexOf(index) + 1), (v, i) => new { Value = v, Index = i });

            double sum = valuesAndIndexes.Select(vi => (double)vi.Value / vi.Index).Sum();

            return Math.Floor(sum);
        }
    }
}
