/* Create a C# program that requests a range of numbers from the user (x, y) and displays them on the screen. */

using System;
public class Range_of_numbers
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter any two numbers for the range");
		int x = int.Parse(Console.ReadLine());
		int y = Convert.ToInt32(Console.ReadLine());
		for(int i = x; i <= y; i++)
		{
			Console.Write(" {0}",i);
		}
    }
}