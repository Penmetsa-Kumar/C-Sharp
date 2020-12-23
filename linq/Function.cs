using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("The Minimum number:{0}", a.Min());
            Console.WriteLine("The Maximum number:{0}", a.Max());
            Console.WriteLine("The Sum of all numbers:{0}", a.Sum());
            Console.WriteLine("The count of numbers:{0}", a.Count());
            Console.WriteLine("Product is {0}", a.Aggregate((b, c) => b + c));
            Console.ReadLine();
        }
    }
}
