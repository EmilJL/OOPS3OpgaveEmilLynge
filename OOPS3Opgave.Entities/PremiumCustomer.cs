using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS3Opgave.Entities
{
    public class PremiumCustomer : Customer
    {
        private decimal monthlyAccountFee;
        private decimal transactionCost;

        public PremiumCustomer(string name, string cpr, ReadOnlyCollection<Account> accounts) : base(name, cpr, accounts)
        {
            this.monthlyAccountFee = MonthlyAccountFee;
            this.transactionCost = TransactionCost;
        }

        public override decimal CalculateCostOfMonth(Month month)
        {
            return base.CalculateCostOfMonth(month);
        }

        public override decimal TransactionCost
        {
            get { return 1.20M; }
        }
        public override decimal MonthlyAccountFee
        {
            get { return 12M; }
        }
    }
}
