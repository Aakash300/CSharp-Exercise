/* Create a C# program that implements a function called Power and calculate the result of raising an integer to another number. */

using System;
					
public class Function_calculating_power
{
	public static void Main()
	{
		int number = Convert.ToInt32(Console.ReadLine());
		int expo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Power(number,expo));
	}
	
	public static int Power(int number, int expo)
	{
		int result = 1;
		for(int i = 0; i < expo; i++)
		{
			result *= number;
		}
		
		return result;
	}
}