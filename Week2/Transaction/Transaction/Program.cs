using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Transaction t = new Transaction();
            t.Amount = 1;
            t.Transactionid = 123;
            t.Productname = "soap";
            t.date = "12april";
            Transaction t1 = new Transaction(t);
            t1.Amount = 2;
            Console.WriteLine(t.Amount);
            Console.WriteLine(t1.Amount);
        }
    }
}
