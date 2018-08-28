using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS3Opgave.Entities
{
    public class SavingAccount : Account
    {
        private decimal interest;   

        public SavingAccount(string accountNumber, decimal balance, ReadOnlyCollection<Transaction> transactions, decimal interest) : base(accountNumber, balance, transactions)
        {
            Interest = interest;
        }

        public decimal AddInterest()
        {
            decimal interestAmount; 
            interestAmount = this.Balance / 100 * this.Interest;
            this.Balance += interestAmount;
            return Balance;
        }
        public decimal Interest
        {
            get { return interest; }
            set { interest = value; }
        }
    }
}
