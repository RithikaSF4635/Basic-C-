using System;
namespace MethodPractice;
class Program{

    static int val1=20;
    static int val2;
    public static void Main(string[] args)
    {
        int a=4;
        int val2=5;
        int ans=multiply(a,val2);
        Console.WriteLine(ans);

        divide(25,5);

        Console.WriteLine(sub());
    }

    static int multiply(int a,int b)
    {
        int c=a*b;
        return c;
    }
    static void divide(int a,int b)
    {
        double c=a/b;
        Console.WriteLine(c);
    }
    static int sub()
    {
        int c=val1-val2;
        return c ;

    }

}
