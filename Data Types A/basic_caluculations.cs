// Write a program in C# that calculates the result of adding, subtracting, multiplying and dividing two numbers entered by the user.

using System;
public class Calculation
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter two numbers:");
        	int  a = Convert.ToInt32(Console.ReadLine());
		int  b = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Add: {0}+{1}={2}",a,b,a+b);
		Console.WriteLine("Sub: {0}-{1}={2}",a,b,a-b);
		Console.WriteLine("Multiply: {0}*{1}={2}",a,b,a*b);
		Console.WriteLine("Divide: {0}/{1}={2}",a,b,a/b);
		Console.WriteLine("Remainder: {0}%{1}={2}",a,b,a%b);

		
    }
}