using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS3Opgave.Entities
{/* skal den virkelig være abstract? */
    public abstract class Customer
    {
        private decimal transactionCost;
        private decimal monthlyAccountFee;
        private string cpr;
        private string name;
        private ReadOnlyCollection<Account> accounts;

        


        protected Customer(string name, string cpr, ReadOnlyCollection<Account> accounts)
        {
            Name = name;
            this.cpr = cpr;
            this.accounts = accounts;
            this.monthlyAccountFee = MonthlyAccountFee;
            this.transactionCost = TransactionCost;
        }

        public ReadOnlyCollection<Account> Accounts
        {
            get { return accounts; }
        }

        public virtual decimal CalculateCostOfMonth(Month month)
        {
            decimal costOfMonth = 0;
            int transactionCount = 0;
            foreach (Account account in Accounts)
            {
                foreach (Transaction transaction in account.Transactions)
                {
                    if ((Month)Enum.Parse(typeof(Month), transaction.DateTimeOfTransaction.ToString("MMMM")) == month)
                    {
                        if (account.AccountType == AccountType.Checking)
                        {
                            if (transactionCount > 20)
                            {
                                costOfMonth += TransactionCost;
                            }
                            else
                            {
                                transactionCount++;
                            }
                        }
                        else
                        {
                            costOfMonth += TransactionCost;
                        }
                    }
                }
                transactionCount = 0;
                costOfMonth += MonthlyAccountFee;
            }
            return costOfMonth;       
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public string CPR
        {
            get { return cpr; }
            //set { cpr = value; }
        }


        public virtual decimal MonthlyAccountFee
        {
            get
            {
                return 15M;
            }
            //set { monthlyAccountFee = value; }
        }


        public virtual decimal TransactionCost
        {
            get { return 1.95M; }
            //set { transactionCost = value; }
        }
    }
}
