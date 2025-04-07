/* Create a program in C# to show odd numbers from x to y in orden descending. */

using System;
					
public class decending_order
{
	public static void Main()
	{
		Console.WriteLine("Enter any highest numbers and then the lowest no:");
		int x = Convert.ToInt32(Console.ReadLine());
		int y = Convert.ToInt32(Console.ReadLine());
		
		if(x%2==0)
		{
			x--;
		}
		while(x>=y)
		{
			Console.WriteLine(x+ " ");
			x -= 2;
		}

	}
}