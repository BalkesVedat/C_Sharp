using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    partial class Computer
    {
        //public double number1;
        //public double number2;
        //public string oprt;

        public double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Sum(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Divide(double n1, double n2)
        {
            if (n2 == 0)
                return 0;
            else
                return n1 / n2;
        }



    }
}
