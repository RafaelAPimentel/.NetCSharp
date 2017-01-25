using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        public double currBalance;
        public static double currIntrestRate;

        public SavingsAccount(double balance)
        {
            currBalance = balance;
            
        }
        static SavingsAccount() {
            Console.WriteLine("In static ctor");
            currIntrestRate = .04;
        }
        public static void setInterestRate(double newRate)
        {
            currIntrestRate = newRate;
        }
        public static double getInterestRate()
        {
            return currIntrestRate;
        }
    }
}
