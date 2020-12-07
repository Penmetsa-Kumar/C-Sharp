using System;
namespace auto
{
  class Program
  { 
    static void Main(string[] args)
    {
      Car myCar = new Car();
      myCar.rpm();
      Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
  }
}