using System;
namespace myinterface
{
   interface Ianimal
   {
       void animal();
   } 
   class dog : Ianimal
   {
       public void animal()
       {
           Console.WriteLine("Dog is a animal");
       }
   }
   class program
   {
       static void Main(string[] args)
       {
           dog mydog = new dog();
           mydog.animal();
       }
   }
}
