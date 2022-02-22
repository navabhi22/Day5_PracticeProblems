using System;

namespace Day5_PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 6 Practice Problems ");
            Console.WriteLine("Enter the value of N to get Nth number of Harmonic Series ");
            int N = Convert.ToInt32(Console.ReadLine());
            HarmonicNumber.HarmonicNum(N);

        }
    }
}