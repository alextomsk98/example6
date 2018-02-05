using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsAcount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Data*****\n");
            SavingsAcount s1 = new SavingsAcount(50);
            Console.WriteLine("Interest Rate is:{0}", SavingsAcount.GetInterestRate());
            SavingsAcount.SetInterestRate(0.08);
            SavingsAcount s2 = new SavingsAcount(100);
            Console.WriteLine("Interest Rate is:{0}", SavingsAcount.GetInterestRate());
            Console.ReadLine();
        }
    }
}
