using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Calculator c = new Calculator();
            char op;
            Console.Write("Enter the operator: ");
            op = char.Parse(Console.ReadLine());

            if (op == '+')
            {
                Console.WriteLine(c.Add());

            }
            else if (op == '-')
            {
                Console.WriteLine(c.subtraction());

            }
            else if (op == '*')
            {
                Console.WriteLine(c.multiply());

            }
            else if (op == '/')
            {
                Console.WriteLine(c.divide());
            }
        }
    }
}
