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
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] counters = { "India","USA","UK","China","Japan","Russia","Dubai","London","Thailand"};
            IEnumerable<int> num = number.Take(4);
            IEnumerable<string> count = counters.Take(5);
            foreach (string s in count)
            {
                Console.WriteLine(s);
            }
            foreach (int n in num)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
