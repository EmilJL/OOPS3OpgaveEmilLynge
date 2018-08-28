using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS3Opgave.Entities
{
    public class Transaction
    {
        private DateTime dateTimeOfTransaction;
        private decimal amount;
        private Account reciever;
        private Account transmitter;    

        public Transaction(decimal amount, Account reciever, Account transmitter)
        {
            this.amount = amount;
            this.reciever = reciever;
            this.transmitter = transmitter;
            this.dateTimeOfTransaction = DateTime.Now;
        }

        public DateTime DateTimeOfTransaction
        {
            get { return dateTimeOfTransaction; }
        }
        public Account Transmitter
        {
            get { return transmitter; }
        }
        public Account Reciever
        {
            get { return reciever; }
        }
        public decimal Amount
        {
            get { return amount; }
        }
    }
}