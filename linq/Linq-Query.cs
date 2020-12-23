using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
	public static void Main()
	{
		IList<Student> studentList = new List<Student>() {
				new Student() { StudentID = 1, StudentName = "pardhu", Age = 13} ,
				new Student() { StudentID = 2, StudentName = "kumar",  Age = 21 } ,
				new Student() { StudentID = 3, StudentName = "Sam",  Age = 28 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
				new Student() { StudentID = 5, StudentName = "Naveen" , Age = 22 },
				new Student() { StudentID = 5, StudentName = "Sim" , Age = 34 },
				new Student() { StudentID = 5, StudentName = "Red" , Age = 49 }
			};

		var teenAgerStudent = from s in studentList
							  where s.Age > 12 && s.Age < 24
							  select s;
		Console.WriteLine("Teen age Students:");

		foreach (Student std in teenAgerStudent)
		{
			Console.WriteLine(std.StudentName);
		}
	}
}

public class Student
{

	public int StudentID { get; set; }
	public string StudentName { get; set; }
	public int Age { get; set; }

}
