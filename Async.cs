using System;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            callMethod();
            Console.ReadKey();
        }

        public static async void callMethod()
        {
            Task<int> task = Method1();
            int count = await task;
            Method2(count);
        }

        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    count += 1;
                }
            });
            return count;
        }

        public static void Method2(int count)
        {
            Console.WriteLine("Total count is " + count);
        }
    }
}