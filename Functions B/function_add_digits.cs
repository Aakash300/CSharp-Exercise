/* Create a C# program that asks the user for a number and save it in a text string. 
You must implement a function called AddDigits that receives the text as a parameter and returns the sum of its digits. */

using System;
					
public class Function_add_digits
{
	public static void Main()
	{

		string number = Console.ReadLine();
		Console.WriteLine(AddDigits(number));
	}
	
	public static int AddDigits(string number)
	{
		int sum = 0;
		for(int i = 0; i < number.Length;i++)
		{
			sum+=Convert.ToInt32(number.Substring(i,1));	
		}
		return sum;
	}
}
