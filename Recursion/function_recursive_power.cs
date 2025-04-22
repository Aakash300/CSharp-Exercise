/*Create a C# program that implements a recursive function that calculates the result of raising an integer to another integer.
  This function must be created recursively.*/

using System;
public class function_recursive_power
{
    public static void Main()
    {
		int number = Convert.ToInt32(Console.ReadLine());
        int exponent = Convert.ToInt32(Console.ReadLine());
		
		 Console.WriteLine(Power(number, exponent));
	}
		
	public static int Power(int number,int exponent)
	{
		if(exponent == 0)
		{
			return 1;
		}
		else
		{
			return number * Power(number, exponent - 1);
		}
	}
}