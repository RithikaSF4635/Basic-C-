using System;
namespace TypeConversion;
class Program
{
    public static void Main(string[] args)
    {
       
       Console.Write("Enter your name: ");
       string name= Console.ReadLine();
       Console.Write("Enter age: ");
       int age= Convert.ToInt32(Console.ReadLine());
       Console.Write("Enter mark of subject1: ");
       double sub1=Convert.ToInt32(Console.ReadLine());
       Console.Write("Enter mark of subject2: ");
       double sub2=Convert.ToInt32(Console.ReadLine());
       Console.Write("Enter mark of subject3: ");
       double sub3=Convert.ToInt32(Console.ReadLine());
       Console.Write("Enter Grade: ");
       Char grade=Convert.ToChar(Console.ReadLine());
       Console.Write("Enter mobile number: ");
       long phone=Convert.ToInt64(Console.ReadLine());
       Console.Write("Enter Mail id: ");
       string mail=Console.ReadLine();
       double avg=(sub1+sub2+sub3)/3;


       Console.WriteLine("Trainee Details Are: ");
       Console.WriteLine("Name: " + name);
       Console.WriteLine("Age: "+ age);
       Console.WriteLine("Mobile: "+ phone);
       Console.WriteLine("MArk1: "+ sub1);
       Console.WriteLine("Mark2: "+ sub2);
       Console.WriteLine("Mark3: "+ sub3);
       Console.WriteLine("Total: " + (sub1+sub2+sub3));
       Console.WriteLine("Average: " + (double.Round(avg,1)));
       Console.WriteLine("Garde: "+ grade);
       Console.WriteLine("Mail id: "+ mail);



    }
}

