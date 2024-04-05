using System;
namespace WhileLoop;
class Program
{
    public static void Main(string[] args)
    {
        int i=0;
        while(i<25)
        {
            if(i%2==0)
            {
                Console.WriteLine(i);
                
            }
            i++;

        }

        Console.WriteLine("Enter a valid number: ");
        int a=0;
        bool number=int.TryParse(Console.ReadLine(),out a);
        while(!number)
        {
            Console.WriteLine("InValid number,Enter again: ");
            number=int.TryParse(Console.ReadLine(),out a);
        }
    }
}
