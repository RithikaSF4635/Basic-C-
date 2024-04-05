using System;
using System.Collections;
namespace SwitchCase;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a value: ");
        double num1=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter a value: ");
        double num2=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter a Operator: ");
        char op=Convert.ToChar(Console.ReadLine());

        switch(op)
        {
            case '+':
            {
            Console.WriteLine(num1+num2);
            break;
            }
            case '-':
            {
            Console.WriteLine(num1-num2);
            break;
            }
            case '/':
            {
                Console.WriteLine(num1/num2);
                break;
            }
            case '*':
            {
                Console.WriteLine(num1*num2);
                break;
            }
            case '%':
            {
                Console.WriteLine(num1%num2);
                break;
            }
            default:
            {
                Console.WriteLine("Invalid Input");
                break;
            }
        }

    }
}
