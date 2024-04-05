using System;
namespace StringManipulation;
class Program{
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter a Long string: ");
       string long_string=Console.ReadLine();
       Console.WriteLine("Enter a shorter string: ");
       string short_string=Console.ReadLine();

       string[] array=long_string.Split(short_string);
       
       Console.WriteLine(array.Length-1);
    }
}
