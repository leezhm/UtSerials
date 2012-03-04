using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    /// <summary>
    /// Bank Account demo class.
    /// </summary>
    public class BankAccount
    {
        private string customerName = "";

        private double totalBalance = 0;

        private bool isFrozen = false;

        private BankAccount()
        {
        }

        public BankAccount(string name, double balance)
        {
            customerName = name;
            totalBalance = balance;
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }
        }

        public double TotalBalance
        {
            get
            {
                return totalBalance;
            }
        }

        public void Debet(double amount)
        {
            if (isFrozen)
            {
                throw new Exception("Warnning : Account Frozen!!!");
            }

            if (amount > totalBalance || 0 > amount)
            {
                throw new ArgumentOutOfRangeException("Warnning : Amount out of range");
            }

            totalBalance -= amount;
        }

        public void Credit(double amount)
        {
            if (isFrozen)
            {
                throw new Exception("Warnning : Account Frozen!!!");
            }

            if (0 > amount)
            {
                throw new ArgumentOutOfRangeException("Warnning : Amount out of range");
            }

            totalBalance += amount;
        }

        private void FreezeAccount()
        {
            isFrozen = true;
        }

        private void UnfreezeAccount()
        {
            isFrozen = false;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr Lee", 15000.00);

            ba.Credit(4500.00);
            ba.Debet(12000.00);
            Console.WriteLine("Current balance is ${0}", ba.TotalBalance);
        }
    }
}
