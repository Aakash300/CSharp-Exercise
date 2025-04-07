/* Write a program in C# which asks the user for an integer number and answers if it is a prime number or not. */

using System;
					
public class PrimeNumber
{
	public static void Main()
	{
		Console.WriteLine("Enter any number:");
		int x = Convert.ToInt32(Console.ReadLine());
		int divider = 2;
		while( x % divider != 0)
		{
			divider++;
		}
		if(divider==x)
		{
			Console.WriteLine("It is a prime number");
		}
		else
		{
			Console.WriteLine("It is not a prime number");
		}
	}
}