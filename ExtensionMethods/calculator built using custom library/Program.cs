using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculation;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float res = 0;
            Console.WriteLine("Enter your action to perfromed");
            Console.WriteLine("Press 1 to Addition");
            Console.WriteLine("Press 2 Substract");
            Console.WriteLine("Press 3 to Multiply");
            Console.WriteLine("Press 4 to Divide");
            float op = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter two number");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            switch(op)
            {
                case 1:
                    {
                        res = Addition(a, b);
                        break;
                    }
                case 2:
                    {
                        res = Substract(a, b);
                        break;
                    }
                case 3:
                    {
                        res = Multiply(a, b);
                        break;
                    }
                case 4:
                    {
                        res = Divide(a, b);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! try again");
                    break;
            }
            Console.WriteLine("The result is {0}",res);
            Console.ReadKey();
        }
        public static float Addition(float a,float b)
        {
            float res = Calculator.Addition(a, b);
            return res;
        }
        public static float Substract(float a,float b)
        {
            float res = Calculator.Substract(a, b);
            return res;
        }

        public static float Multiply(float a, float b)
        {
            float res = Calculator.Multiply(5, 2);
            return res;
        }
        public static float Divide(float a, float b)
        {
            float res = Calculator.Divide(a, b);
            return res;
        }
        
    }
}
