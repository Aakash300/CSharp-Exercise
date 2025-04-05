/* Write a C# program that requests a number (x) and answers if it is positive or negative. */

using System;
public class PositiveAndNegative
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter a numbers");
		int x1 = Convert.ToInt32(Console.ReadLine());
		if(x1 >= 0)
		{
			Console.WriteLine("It is a positive Number");
		}
		else
		{
			Console.WriteLine("It is a Negative Number");
		}
		
    }
}