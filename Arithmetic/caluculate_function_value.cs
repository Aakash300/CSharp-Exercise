// Create a program C# to display certain values of the function y= x2 - 2x + 1. Ask the user for the range of integers x to show the function.

using System;
public class  CalculateValuesFunction
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter number:");
        int x1 = Convert.ToInt32(Console.ReadLine());
		int x2 = Convert.ToInt32(Console.ReadLine());
		for(int x = x1; x<=x2 ; x++)
		{
			int z = x*x-2*x+1;
			Console.WriteLine(z);
		}

		
    }
}