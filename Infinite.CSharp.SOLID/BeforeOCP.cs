using System;

namespace Infinite.CSharp.SOLID
{
    public class Account
    {
        public int CustomerId { get; set; }
        public string AccountNo { get; set; }
        public string Name { get; set; }
        public string AccountType { get; set; }
        public double Amount { get; set; }


        public Account()
        {

        }

        public Account(int customerId, string accountNo, string name, string accountType, double amount)
        {
            CustomerId = customerId;
            AccountNo = accountNo;
            Name = name;
            AccountType = accountType;
            Amount = amount;
        }

        public void CreateAccount()
        {
            Console.WriteLine("Account Created");
        }

        public void CreateNewFixedDeposit(double amount, float intersetRate, int noOfMonths)
        {

        }
    }

    public class AccountV2 : Account
    {
        public float InterestRate { get; set; }
        public int NoOfMonths { get; set; }
    }

    public class FDAccount : AccountV2
    {

        //public string LoanType { get; set; }
        //public FDAccount(int customerId, string accountNo, string name, string accountType, double amount, float interestRate, int noOfMonths) : base(customerId, accountNo)
        //{
        //    InterestRate = interestRate;
        //    NoOfMonths = noOfMonths;
        //}

    }

    public class RDAccount : AccountV2
    {
        public void Get ()
        {
            AccountNo = "11111";
            InterestRate = 5;
            NoOfMonths = 12;
        }
    }

    public class CurrentAccount : Account
    {
        public void Get()
        {
            AccountNo = "1111";
          
        }
    }
}
