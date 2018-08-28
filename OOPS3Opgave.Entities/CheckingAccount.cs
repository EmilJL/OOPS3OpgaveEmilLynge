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
        public CheckingAccount(string accountNumber, decimal balance, ReadOnlyCollection<Transaction> transactions, int NoMonthlyFreeTransactions = 20) : base(accountNumber, balance, transactions)
        {
        }
    }
}
