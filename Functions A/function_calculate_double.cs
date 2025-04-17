/*Create a C# program that implements a function called Double to calculate and return double an integer. You must first request the number from the user.*/

using System;
					
public class Function_calculate_double
{
	public static void Main(string[] args)
    {
		int numbers = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(Double(numbers));
    }
	
	public static int Double(int numbers)
	{
		return numbers+numbers;
	}
}