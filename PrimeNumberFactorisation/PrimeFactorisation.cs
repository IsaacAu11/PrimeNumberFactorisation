using System;
using System.Collections.Generic;

namespace PrimeNumberFactorisation
{
    class PrimeFactorisation
    {
        static bool Search(List<int> primes, int n) 
        {
            for (int i = 0; i < primes.Count; i++)
            {
                if (n == primes[i])
                {
                    return true;
                }
            }
            return false;
        }

        static void PrimeFactoriastion(int num)
        {
            int mod;
            int n = 2;
            bool isFinished = false;
            List<int> UniquePrimeFactors = new List<int>() { };

            while (isFinished == false)
            {
                mod = num % n;
                if (mod == 0)
                {
                    Console.WriteLine(n + " is a prime factor");
                    if (Search(UniquePrimeFactors,n) == false)
                    {
                        UniquePrimeFactors.Add(n);
                    } 
                    if (num / n == 1)
                    {
                        isFinished = true;
                    }
                    num = num / n;
                }
                else
                {
                    n++;
                }
            }
            Console.WriteLine();
            int productTotal = 1;
            foreach (int item in UniquePrimeFactors)
            {
                productTotal = productTotal * item;
            }
            Console.WriteLine("Product of unique primes = "+productTotal);
        }


        static void Main(string[] args)
        {
            Console.Write("Input a number : ");
            PrimeFactoriastion(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
