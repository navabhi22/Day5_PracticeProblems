using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_PracticeProblems
{
    public class PrimeNumber
    {
        /// <summary>
        /// Checks for the Prime number.
        /// </summary>
        /// <param name="N">The n.</param>
        /// <returns></returns>
        public static bool PrimeNum(int N)
        {
            int numOfFact = 0;
            for (int i = 1; i <= N; i++)
            {
                int rimainder = N % i;

                if (rimainder == 0)
                {
                    numOfFact++;
                }

            }

            if (numOfFact == 2)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
    }
}