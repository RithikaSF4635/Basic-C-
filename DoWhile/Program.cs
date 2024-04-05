using System;
namespace DoWhile;
class Program
{
    public static void Main(string[] args)
    {
        string say="";
       do
       {
        Console.WriteLine("Enter a number: ");
        int number=Convert.ToInt32(Console.ReadLine());
        
        if (number%2==0)
        {
            Console.WriteLine(number +" is a even number");
        }
        else
        {   
            Console.WriteLine(number +" is odd number");
        }

        do
        {
            Console.Write("Need to Repeat:");
            say=Console.ReadLine();
            if(say=="yes")
            {
              continue;  
            }
            else if (say=="no")
            {
                break;
            }
            else
            {
                Console.WriteLine("Say yes or no");
            }
        }while(say!="yes"&& say!="no");
            
        
       }while(say =="yes"); 
    }
}
