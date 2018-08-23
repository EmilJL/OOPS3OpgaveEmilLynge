using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS3Opgave.Entities
{
    public abstract class Customer
    {
        private decimal transactionCost;
        private decimal monthlyAccountFee;
        private string cpr;
        private string name;
        
        public Customer(string name, string cpr, Account account)
        {
            Name = name;
            CPR = cpr;
            MonthlyAccountFee = CalculateCostOfMonth(, )
        }

        public decimal CalculateCostOfMonth(Month month, decimal monthlyAccountFee, decimal transactionCost)
        {
            return 0;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public string CPR
        {
            get { return cpr; }
            set { cpr = value; }
        }


        public decimal MonthlyAccountFee
        {
            get { return monthlyAccountFee; }
            set { monthlyAccountFee = value; }
        }


        public decimal TransactionCost
        {
            get { return transactionCost; }
            set { transactionCost = value; }
        }

    }
}
