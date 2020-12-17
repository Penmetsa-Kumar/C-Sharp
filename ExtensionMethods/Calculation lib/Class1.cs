using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public static class Calculator 
    {
        public static float Addition(float a,float b)
        {
            return a + b;
        }
        public static float Substract(float a, float b)
        {
            return a - b;
        }

        public static float Multiply(float a, float b)
        {
            return a * b;
        }

        public static float Divide(float a, float b)
        {
            return a / b;
        }   

        public static float Power(float a)
        {
            return a * a;
        }
    }
}
