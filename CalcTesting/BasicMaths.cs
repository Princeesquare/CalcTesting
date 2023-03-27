using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTesting
{
    public class BasicMaths
    {
        static void Main(string[] args)
        {
            BasicMaths obj = new BasicMaths();
            obj.Add(2, 3);
        }
        public double Add(double num1, double num2)
        {
            return num1 + num2; 
        }
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Divide(double num1, double num2)
        {
            return (num1 / num2);
        }
        public double Mul(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
