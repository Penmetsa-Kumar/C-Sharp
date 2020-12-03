using System;
namespace adding
   {
       class pro
       {
           static void Main(string[] args)
           {
               Console.WriteLine("Enter first name and last name");
               string fname = Console.ReadLine(), lname = Console.ReadLine();
               Console.WriteLine("Enter Age");
               int age = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Enter the phone number");
               long phone = Convert.ToInt64(Console.ReadLine());
               Console.WriteLine("Welcome " + fname +" "+ lname + "\n your age:"+ age);
               if(phone.ToString().Length == 10)
               {
                   Console.WriteLine("phone.no:"+phone);
               }
               else
               {
                   Console.WriteLine("Phone no is Invalid");
               }
               
           }
       }
   }
