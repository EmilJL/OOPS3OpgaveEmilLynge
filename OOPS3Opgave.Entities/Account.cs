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

        protected Account(string accountNumber, decimal balance, ReadOnlyCollection<Transaction> transactions)
        {
            this.transactions = transactions;
            this.balance = balance;
            this.accountNumber = accountNumber;
        }
        public bool Processor(Transaction t)
        {
            try
            {
                t.Reciever.Balance += t.Amount;
            }
            catch (Exception)
            {
                throw;
            }
            try
            {
                t.Transmitter.balance += t.Amount;
            }
            catch (Exception)
            {

                throw;
            }

            return true;
        }
        public ReadOnlyCollection<Transaction> Transactions
        {
            get { return transactions; }
        }
        public decimal Balance
        {
            get { return balance; }
            protected set { balance = value; }
        }
    }
}