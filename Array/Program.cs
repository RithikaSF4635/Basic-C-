using System;
namespace Array;
class Program
{
    public static void Main(string[] args)
    {
        string[] array=new string[5];

        for (int i=0;i<array.Length;i++)
        {
            array[i]=Console.ReadLine();
            //Console.WriteLine(array[i]);
            
        }

        Console.Write("Enter a name to search in array: ");
        string name=Console.ReadLine();
        bool flag=true;
        for(int j=0;j<array.Length;j++)
        {
            if (name == array[j])
            {
                flag=false;
                Console.WriteLine("The name is present in array.");
               
            }
            
        }
        if(flag)
        {
            Console.WriteLine("The name is not present in array.");
        }
        
        foreach( string k in array)
        {
            if (k== name)
            {
                flag=false;
                Console.WriteLine("The name is present in array.");
               
            }
        }
        if(flag)
        {
            Console.WriteLine("The name is not present in array.");
        }
        
    }
}
