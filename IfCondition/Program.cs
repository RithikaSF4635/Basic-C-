using System;
namespace IfCondition;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Mark: ");
        double mark=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Mark= "+ mark);
        if (mark>=80)
        {
             Console.WriteLine("Grade A");
        }
       
        else if (mark>60 && mark<80)
        {
            Console.WriteLine("Grade B");
        }
        
        else if (mark>35 && mark<=60)
        {
            Console.WriteLine("Grade C");
        }
        
        else if (mark<36)
        {
            Console.WriteLine("Garde D");
        }
        else if (mark>100)
        {
            Console.WriteLine("Invalid Input");
        }
        else if (mark<0)
        {
            Console.WriteLine("Invalid Input");
        }
        else
        {
            Console.WriteLine("Invalide Input");
        }
        
        
    }
}
