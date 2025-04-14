/* Create a C# program that asks the user for 5 integers to store them in an array of integers and display them in reverse order. */

using System;
					
public class array_reverse
{
	public static void Main()
	{
		Console.WriteLine("Enter 5 intergers");
		int total = 5;
		int[] numbers = new int[total];
		
		for(int i = 0; i<total; i++)
		{
			numbers[i]= Convert.ToInt32(Console.ReadLine());
		}
		
		Array.Reverse(numbers);
		
		for(int i = 0; i<total;i++)
		{
			Console.Write("{0} ",numbers[i]);
		}
	}
}