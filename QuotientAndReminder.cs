using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_PracticeProblems
{
    public class QuotientAndReminder
    {
        /// <summary>
        /// Calculate Quotient and Reminder
        /// </summary>
        public static void FindQuotientAndReminder(int dividend, int devisor)
        {
            
            int quotient = dividend / devisor;
            int reminder = dividend % devisor;

            Console.WriteLine("Dividend : {0} Devisor {1}", dividend, devisor);
            Console.WriteLine("Quotient " + quotient);
            Console.WriteLine("Reminder " + reminder);
        }
    }
}
