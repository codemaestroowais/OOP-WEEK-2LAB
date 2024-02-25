using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        public Calculator() 
        {
            num1 = 10;
            num2 = 10;
        }
        public Calculator(float first_value , float second_value) 
        {
            num1 = first_value;
            num2 = second_value;
        }
        public float num1;
        public float num2;

        public float Add()
        {
            return num1 + num2;
        }
        public float subtraction()
        {
            return num1 - num2;
        }
        public float multiply() 
        {
            return (num1 * num2);
        }
        public float divide() 
        {
            return (num1 / num2);
        }
    }
}
