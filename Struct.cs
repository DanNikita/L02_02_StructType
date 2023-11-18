using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructType
{
    public enum AccountType { Checking, Deposit }
    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType AccType;
    }
    internal class Struct
    {
        static void Main(string[] args)
        {
            BankAccount goldAccount;
            goldAccount.AccType = AccountType.Checking;
            goldAccount.accBal = (decimal) 3200.00;
            Console.Write("Enter account number: ");
            goldAccount.accNo = long.Parse(Console.ReadLine());
            //goldAccount.accNo = 1234;
            Console.WriteLine("Account Number {0}", goldAccount.accNo);
            Console.WriteLine("Account Type {0}", goldAccount.AccType);
            Console.WriteLine("Account Balance ${0}", goldAccount.accBal);
            Console.ReadLine();
        }
    }
}
