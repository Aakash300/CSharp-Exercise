/* Write a program in C# to calculate and display the absolute value of a number x.

If the number is positive, its absolute value is exactly the number x. If it is negative, its absolute value is -x. */

using System;
					
public class absolute_value
{
	public static void Main()
	{
		Console.WriteLine("Enter any number:");
		int num = Convert.ToInt32(Console.ReadLine());
		int abs;
		if(num<0)
		{
			abs= -num;
		}
		else
		{
			abs= num;
		}
		Console.WriteLine("Absolute value is {0}",abs);
	}
}