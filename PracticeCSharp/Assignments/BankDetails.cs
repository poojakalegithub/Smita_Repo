using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.Assignments
{
    internal class BankDetails
    {
        public string name;
        public double balance = 0;

        public BankDetails(string namae, double firstDep)
        {
            name = namae;
            balance += firstDep;
        }

        public double getBal()
        {
            return balance;
        }

        public string getName()
        {
            return this.name;
        }

        public void deposit(double addAmt)
        {
            balance += addAmt;
        }

        public bool withdraw(double outAmt)
        {
            bool chk = true;
            if (outAmt <= balance)
            {
                balance -= outAmt;
            }
            else if (outAmt > balance)
            {
                chk = false;
            }
            return chk;
        }

        
    
}
}
