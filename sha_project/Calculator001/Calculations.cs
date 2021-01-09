using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCalulator
{
    class Calculation
    {
        public double Number { get; set; }
        public double Number2 { get; set; }
        public string op { get; set; }
        

        public static double Addition(Double Number2, Double Number)
        {
            return Number2 + Number;
        }
        public static double Multiplication(Double Number2, Double Number)
        {
            return Number2 * Number;
        }
        public static double Division(Double Number2, Double Number)
        {
            return Number2 / Number;
        }
        public static double Subtraction(Double Number2, Double Number)
        {
            return Number2 - Number;
        }
    }
}
