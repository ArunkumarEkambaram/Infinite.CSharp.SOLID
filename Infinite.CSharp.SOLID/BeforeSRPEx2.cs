using System;

namespace Infinite.CSharp.SOLID
{
    public class MyBank
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        //public void CreateAccount()
        //{

        //}
        //public void ApplyLoan()
        //{
        //    Console.WriteLine("Apply loan");
        //}

        //public void Deposit(double amount)
        //{
        //    Console.WriteLine("Amount deposited");
        //}

        //public double WithdrawCash(string accNo)
        //{
        //    return 0.0;
        //}

        //public void ClosingLoan(int id)
        //{
        //    Console.WriteLine("Your loan has been successfully Closed");
        //}


    }

    public class LoanManagement : MyBank
    {
        public void ApplyLoan()
        {
            Console.WriteLine("Apply loan");
        }

        public void ClosingLoan(int id)
        {
            Console.WriteLine("Your loan has been successfully Closed");
        }

    }

    public class Transaction : MyBank
    {
        public void Deposit(double amount)
        {
            Console.WriteLine("Amount deposited");
        }

        public double WithdrawCash(string accNo)
        {
            return 0.0;
        }
    }

    public class AccountService : MyBank
    {
        public void CreateAccount()
        {

        }

        public void ClosingAccount()
        {

        }
    }
}
