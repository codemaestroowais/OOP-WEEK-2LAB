using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Atm
    {
        public Atm() 
        {
            balance = 30000;
        }
        public int balance;
        public List<string> history = new List<string> ();

        public float deposit()
        {
            int total = 0;
            total += balance;
            return total;
        }

        public int withdraw ()
        {
            return balance - 1000;
        }
        public int check_balance()
        {
            return balance;
        }

        public void check(string balance)
        {
            history.Add(balance);

       }
    }
}
