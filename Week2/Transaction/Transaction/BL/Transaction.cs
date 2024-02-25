using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction
{
    internal class Transaction
    {
        public Transaction() 
        { 

        }
        public Transaction(Transaction t)
        {
            Transactionid = t.Transactionid;
            Productname = t.Productname;
            Amount = t.Amount;
            date = t.date;
            time = t.time;
        }
        

        public int Transactionid;
        public string Productname;
        public int Amount;
        public string date;
        public string time;

    }
}
