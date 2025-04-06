/* Write a program in C# that asks for a number (x) and a amount (y). Show that number as many times as the amount (y). */

using System;
					
public class repeating_numbers
{
	public static void Main()
	{
		Console.WriteLine("Enter a number and enter nummber of repeatation");
		int x = Convert.ToInt32(Console.ReadLine()); 
		int y = Convert.ToInt32(Console.ReadLine());
		for(int i = 0; i<=y; i++)
		{
			Console.Write(x);
		}
		
	}
}