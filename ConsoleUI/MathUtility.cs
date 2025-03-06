using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTools
{
    public class MathUtility
    {
        public static double Add(double x, double y)
        {
            double output = 0;
            output = x + y;
            return output;
        }

        public static double Subtract(double x, double y) 
        { 
            double output = 0;
            output = x - y;
            return output;
        
        }

        public static double Multiply(double x, double y) 
        {
            double output = 0;
            output = x * y;
            return output;
        }

        public static double Divide(double x, double y) 
        {
            double output = 0;
            output = x / y;
            return output;
        
        }
    }
}
