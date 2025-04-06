/* Create a C# program that asks the user for a range of numbers (x, y) and displays the multiplication tables from x to y. */

using System;
					
public class infinite_multiplication_table
{
	public static void Main()
	{
		Console.WriteLine("Enter two value for all the table");
		int x1 = Convert.ToInt32(Console.ReadLine()); 
		int x2 = Convert.ToInt32(Console.ReadLine());
		for( int i = x1; i<=x2; i++)
		{
			for( int j = 1; j<=10;j++)
			{
				Console.WriteLine("{0}x{1}={2}",i,j,i*j);
			}
			Console.WriteLine();
		}
				
	}
}