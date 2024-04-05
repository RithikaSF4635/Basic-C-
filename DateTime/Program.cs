using System;
namespace DateAndTime;
class Program
{
    public static void Main(string[] args)
    {
        DateTime date=new DateTime(2021,8,10,10,40,32);
        Console.WriteLine(date.Day);
        Console.WriteLine(date.Month);
        Console.WriteLine(date.Year);
        Console.WriteLine(date.Hour);
        Console.WriteLine(date.Minute);
        Console.WriteLine(date.Second);

        Console.WriteLine(date.ToString("2021,8,10,10,40,32"));
        
        string date1=Console.ReadLine();

        string[] date2=date1.Split(',','/',' ');

        for(int i=date2.Length-1;i>=0;--i)
        {
            
            //string[] array=new string[date2.Length];
            Console.Write(date2[i]+ ' ');
        }
        
        
    }
}
