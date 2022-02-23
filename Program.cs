using System;

namespace Day5_PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 6 Practice Problems ");
            Console.WriteLine("Enter the number to calculate it's Prime Factors");
            int N = Convert.ToInt32(Console.ReadLine());    

            PrimeFactors.PrimeFactor(N);
        }
    }
}