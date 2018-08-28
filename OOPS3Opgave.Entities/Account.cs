using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS3Opgave.Entities
{
    public abstract class Account
    {
        private ReadOnlyCollection<Transaction> transactions;
        private decimal balance;
        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
        }


        //private AccountType accountType;

        //public AccountType AccountType
        //{
        //    get { return accountType; }
        //    set { accountType = value; }
        //

        protected Account(string accountNumber, decimal balance, ReadOnlyCollection<Transaction> transactions)
        {
            this.transactions = transactions;
            this.balance = balance;
            this.accountNumber = accountNumber;
        }

        public ReadOnlyCollection<Transaction> Transactions
        {
            get { return transactions; }
        }
        public decimal Balance
        {
            get { return balance; }
        }

        //public decimal MyProperty
        //{
        //    get { return Balance; }
        //} 

    }
}
