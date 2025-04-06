/* Create a C# program that asks the user for two integers (x, y) and shows the range of those numbers (the two included), in three different ways:

Using the for statement.
Using the while statement.
Using the do while instruction. */

using System;
					
public class RepetitiveStructures
{
	public static void Main()
	{
		Console.WriteLine("Enter a range of no.s");
		int low = Convert.ToInt32(Console.ReadLine());
		int up = int.Parse(Console.ReadLine());
		for(int i = low; i<=up;i++)
		{
			Console.Write(" {0}",i);
		}
		Console.WriteLine();
		
		int x = low;
		do
		{
			Console.Write(" {0}",x);
			x++;
		}
		while(x<=up);
		
		Console.WriteLine();
		
		while(low<=up)
		{
			Console.Write(" {0}",low);
			low++;	
		}
		
	}
}