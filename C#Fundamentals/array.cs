using System;
using System.Collections.Generic;

namespace array
    {
        class pro
        {
            static void Main(string[] args)
            {
                var grades = new List<double>() {15.5,25.21,10.9,65.3,12.6};
                grades.Add(43.23);
                var result = 0.0;
                foreach(var number in grades)
                {
                    result += number;
                }
                result /= grades.Count;
                Console.WriteLine($"The average grade is {result:N0}");
                Console.WriteLine($"The average grade is {result:N1}");
                Console.WriteLine($"The average grade is {result:N2}");   
            }

        }
    }
