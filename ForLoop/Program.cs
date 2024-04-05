using System;
namespace ForLoop;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the start number: ");
        int start=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the end number: ");
        int end=Convert.ToInt32(Console.ReadLine());
        int Total=0;
        
        for(int i=start;i<=end;i++)
        {
            Total+=(i*i); 
        }
        Console.WriteLine("Sum of the Square from two number limits: " + Total);
    }
}