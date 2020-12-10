using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    static class Class1
    {
        public static void method4(this Program P)
        {
            Console.WriteLine("method 4");
        }
        public static void method5(this Program P)
        {
            Console.WriteLine("method 5");
        }
    }
}
