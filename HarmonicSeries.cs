using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_PracticeProblems
{
    public class HarmonicNumber
    {
        /// <summary>
        /// Nth number of Harmonic Series.
        /// </summary>
        /// <param name="N">The n.</param>
        public static void HarmonicNum(int N)
        {
            double HarmonicSum = 0;
            if (N > 0)
            {
                for (double i = 1; i <= N; i++)
                {
                    HarmonicSum = HarmonicSum + 1 / i;

                }

                Console.WriteLine("the Nth harmonic value is " + HarmonicSum);

            }
            else
            {
                Console.WriteLine(" N should be greter than 0 ");
            }
        }
    }
}
