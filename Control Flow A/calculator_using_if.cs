/* Write a program in C# that asks the user for two numbers and one operation (+, -, x, /) then calculate the operation and display the result on the screen.

Show the text Unrecognized character if the operation symbol is different from the previous ones.

You should use the if block. */

using System;
public class calculator_using_if
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter two numbers");
		int x1 = Convert.ToInt32(Console.ReadLine());
		int x2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter operator like +,-,*,/");
		char op = char.Parse(Console.ReadLine());
		
		if(op == '+')
		{
			Console.WriteLine("{0}+{1}={2}",x1,x2,x1+x2);
		}
		else if(op == '-')
		{
			Console.WriteLine("{0}-{1}={2}",x1,x2,x1-x2);
		}
		else if(op == '*' || op== 'x' || op == 'X')
		{
			Console.WriteLine("{0}*{1}={2}",x1,x2,x1*x2);
		}
		else if(op=='/')
		{
			Console.WriteLine("{0}/{1}={2}",x1,x2,x1/x2);
		}
		else
		{
			Console.WriteLine("Unrecognized Character");
		}
    }
}