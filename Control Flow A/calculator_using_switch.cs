/* Write a program in C# that asks the user for two numbers and one operation (+, -, x, /) then calculate the operation and display the result on the screen.

Show the text Unrecognized character if the operation symbol is different from the previous ones.

You should use the switch block. */

using System;
public class calculator_using_switch
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter two numbers");
		int x1 = Convert.ToInt32(Console.ReadLine());
		int x2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter operator like +,-,*,/");
		char op = char.Parse(Console.ReadLine());
		
		switch(op)
		{
			case '+':
			Console.WriteLine("{0}+{1}={2}",x1,x2,x1+x2);
			break;
			case '-':
			Console.WriteLine("{0}-{1}={2}",x1,x2,x1-x2);
			break;
			case '*' :
			case 'x' :
			case 'X':
			Console.WriteLine("{0}*{1}={2}",x1,x2,x1*x2);
			break;
			case '/' :
			Console.WriteLine("{0}/{1}={2}",x1,x2,x1/x2);
			break;
			default:
			Console.WriteLine("Unrecognized Character");
			break;
		}
    }
}