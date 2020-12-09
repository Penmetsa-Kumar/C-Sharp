using System;

namespace myapp
{
    public class Program
    {
        public delegate void Print(int value);
        public static void Main()
        {
            Print print = delegate (int val)
            {
                Console.WriteLine("working: {0}", val);
            };
            print(100);
        }
    }
}
