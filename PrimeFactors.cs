using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_PracticeProblems
{
    public class PrimeFactors
    {
        /// <summary>
        /// Calculate the Primefactors.
        /// </summary>
        /// <param name="N">The n.</param>
        public static void PrimeFactor(int N)
        {

            for (int i = 1; i <= N; i++)
            {

                int y = N % i;
                if (y == 0 && PrimeNumber.PrimeNum(i) == true)
                {

                    Console.Write(i + "  ");

                }

            }

        }
    }
}