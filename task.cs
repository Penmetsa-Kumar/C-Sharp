using System;
using System.Threading.Tasks;

namespace TaskExmaple

{
    class program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() =>
            {
                for (int a=0; a<10; a++)
                {
                    Console.WriteLine("working");
                }
            });
            t.Wait();
        }

    }
}
