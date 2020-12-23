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
            Console.WriteLine("Sorting Operators");
            List<student> objstu = new List<student>()
            {
                new student() { RoleId = 1, Name = "Suresh", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics" } },
                new student() { RoleId = 2, Name = "kumar", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics"} },
                new student() { RoleId = 3, Name = "Pardhu", Gender = "Male", Subjects = new List<string> { "Computers", "Charted" } },
                new student() { RoleId = 4, Name = "Naveen", Gender = "Male",Subjects = new List<string> { "Mathematics", "Charted" } },
                new student() { RoleId = 5, Name = "Sonu", Gender = "Female",Subjects = new List<string> { "Computers", "Mathematics" } },
                new student() { RoleId = 6, Name = "Padma", Gender = "female",Subjects = new List<string> { "Computers", "Physics" } },
                new student() { RoleId = 7, Name = "Priya", Gender = "female",Subjects = new List<string> { "Operating System", "Python" } },
            };
            Console.WriteLine("-----ORDER BY-----");
            var stuname = objstu.OrderBy(a=>a.Name);
            foreach(var stu in stuname)
            {
                Console.WriteLine(stu.Name);
            }
            Console.WriteLine("-----ORDER BY DESCENDING-----");
            var stunam = objstu.OrderByDescending(a => a.Name);
            foreach (var stu in stunam)
            {
                Console.WriteLine(stu.Name);
            }
            Console.WriteLine("-----THEN BY-----");
            var stuname1 = objstu.OrderBy(a => a.Name).ThenBy(a => a.RoleId);
            foreach (var stu in stuname1)
            {
                Console.WriteLine("Name:{0} RoleID:{1}",stu.Name,stu.RoleId);
            }
            Console.WriteLine("-----THEN BY DESCENDING-----");
            var stuname2 = objstu.OrderBy(a => a.Name).ThenByDescending(a => a.RoleId);
            foreach (var stu in stuname2)
            {
                Console.WriteLine("Name:{0} RoleID:{1}", stu.Name, stu.RoleId);
            }
            Console.ReadLine();
        }
    }
class student
{
    public int RoleId { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public List<string> Subjects { get; set; }
}
}
