using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsAcount
{
    class SavingsAcount
    {
        public double currBalance;
        public static double currInterestRate;
        public SavingsAcount(double balance)
        {
            currInterestRate = 0.04;
            currBalance = balance;
        }
        static SavingsAcount()
        {
            Console.WriteLine("in static ctor!");
            currInterestRate = 0.04;
        }
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }
        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }
}
