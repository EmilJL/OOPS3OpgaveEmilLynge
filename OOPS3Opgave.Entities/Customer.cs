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
            List<SavingAccount> savingAccounts = new List<SavingAccount>();
            List<CheckingAccount> checkingAccounts = new List<CheckingAccount>();
            foreach (Account account in Accounts)
            {
                
                if (account.GetType() == typeof(SavingAccount))
                {
                    savingAccounts.Add(account as SavingAccount);
                }
                else if (account.GetType() == typeof(CheckingAccount))
                {
                    checkingAccounts.Add(account as CheckingAccount);
                }

                //transactionCount = 0;
                //costOfMonth += MonthlyAccountFee;
            }
            foreach (SavingAccount account in savingAccounts)
            {
                foreach (Transaction transaction in account.Transactions)
                {
                    if ((Month)Enum.Parse(typeof(Month), transaction.DateTimeOfTransaction.ToString("MMMM")) == month)
                    {
                        costOfMonth += TransactionCost;
                    }
                }
                costOfMonth += MonthlyAccountFee;
            }
            foreach (CheckingAccount account in checkingAccounts)
            {
                foreach (Transaction transaction in account.Transactions)
                {
                    if ((Month)Enum.Parse(typeof(Month), transaction.DateTimeOfTransaction.ToString("MMMM")) == month)
                    {
                        if (account.NoMonthlyFreeTransactions > 0)
                        {
                            account.NoMonthlyFreeTransactions--;
                        }
                        else
                        {
                            costOfMonth += TransactionCost;
                        }
                    }
                }
                costOfMonth += TransactionCost;
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
