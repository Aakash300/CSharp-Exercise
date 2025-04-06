/* Create a program in C# to calculate how many digits has a positive integer.

If the user enters a negative integer, the program must show a warning message, and proceed with the equivalent positive number. */

using System;
					
public class DigitsNumber
{
	public static void Main()
	{
		Console.WriteLine("Enter a number");
		int num = Convert.ToInt32(Console.ReadLine());
		int digits = 0;
		if(num < 0)
		{
			Console.WriteLine("Warning: it is a negative number");
			num = -num;
		}
		while(num>0)
		{
			num/= 10; //num = num/10;
			digits++;
		}
		if(digits==0)
		{
			digits = 1;
		}
		
		Console.WriteLine("{0} digits",digits);
		
		
	}
}