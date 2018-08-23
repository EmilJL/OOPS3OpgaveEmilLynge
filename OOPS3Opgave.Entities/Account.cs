using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS3Opgave.Entities
{
    public abstract class Account
    {
        private decimal Balance;
        private bool myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        public decimal MyProperty
        {
            get { return Balance; }
        }

    }
}
