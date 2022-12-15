using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite.CSharp.SOLID
{
    public abstract class AccountTransaction
    {
        public abstract bool Deposit(double amount);

        public abstract double Withdraw(string accNo, double amount);

        public abstract double Overdraft(string accNo, double amount);

    }

    public class IEBISavingsAccount : AccountTransaction
    {
        public override bool Deposit(double amount)
        {
            Console.WriteLine($"Amount of Rs.{amount} deposited successfully");
            return true;
        }

        public override double Overdraft(string accNo, double amount)
        {
            throw new NotImplementedException("No overdraft allowed");
        }

        public override double Withdraw(string accNo, double amount)
        {
            Console.WriteLine($"Amount of Rs.{amount} withdrawn successfully");
            return 1000;
        }
    }

    public class IEBICurrentAccount : AccountTransaction
    {
        public override bool Deposit(double amount)
        {
            Console.WriteLine($"Amount of Rs.{amount} deposited successfully");
            return true;
        }

        public override double Overdraft(string accNo, double amount)
        {
            Console.WriteLine($"Overdraft of Rs.{amount} has been successfully withdrawn");
            return -50000;
        }

        public override double Withdraw(string accNo, double amount)
        {
            Console.WriteLine($"Amount of Rs.{amount} withdrawn successfully");
            throw new NotImplementedException();
        }
    }
}
