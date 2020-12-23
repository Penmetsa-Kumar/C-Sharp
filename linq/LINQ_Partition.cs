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
            string[] counters = { "USA", "UK", "India","China","Japan","Russia","Dubai","London","Thailand"};
            IEnumerable<string> count = counters.Take(5);
            IEnumerable<string> count1 = counters.Skip(6);
            IEnumerable<string> count2 = counters.TakeWhile(z=>z.StartsWith("U"));
            Console.WriteLine("-----Take-----");
            foreach(string s in count)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-----Skip-----");
            foreach(string s in count1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-----TakeWhile-----");
            foreach(string s in count2)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
