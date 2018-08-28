using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS3Opgave.Entities
{
    public class CheckingAccount : Account
    {
        private int noMontlyFreeTransactions;

        public CheckingAccount(string accountNumber, decimal balance, ReadOnlyCollection<Transaction> transactions, int noMonthlyFreeTransactions = 20) : base(accountNumber, balance, transactions)
        {
            this.NoMonthlyFreeTransactions = noMonthlyFreeTransactions;
        }

        public int NoMonthlyFreeTransactions
        {
            get { return noMontlyFreeTransactions; }
            set { noMontlyFreeTransactions = value; }
        }
    }
}