using System;

public class Program
{
	delegate bool IsTeenAger(Student stud);

	public static void Main()
	{
		IsTeenAger isTeenAger = s => s.Age > 12 && s.Age < 20;

		Student stud = new Student() { Age = 25 };

		Console.WriteLine(isTeenAger(stud));


	}
}

public class Student
{

	public int Id { get; set; }
	public string Name { get; set; }
	public int Age { get; set; }
}
