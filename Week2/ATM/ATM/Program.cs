using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Atm atm = new Atm();
            menu();
            string choice;
            Console.WriteLine("Enter your choice:");
            choice = Console.ReadLine();

            
            if(choice=="1")
            {
                Console.WriteLine(atm.deposit());
            }
            else if(choice == "2")
            {
                Console.WriteLine(atm.withdraw());
            }
            else if(choice == "3")             {
                Console.WriteLine(atm.check_balance());
            }

            for(int i=0; i<atm.history.Count;i++ ) 
            {
                atm.check();
            }
        }

        static void menu()
        {
            Console.WriteLine("1.Add amount.");
            Console.WriteLine("2.withdraw amount");
            Console.WriteLine("3.check balance");
            Console.WriteLine("4.transaction history");
        }
    }
}
