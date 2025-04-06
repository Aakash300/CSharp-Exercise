/* Create a C# program that shows numbers 1 through 500 that are multiples of 3 and also multiples of 5. */

using System;
					
public class multiples_of_three_and_five
{
	public static void Main()
	{
		Console.WriteLine("Enter a lower limit and upper limit to get multiples of 3 and 5");
		int x = Convert.ToInt32(Console.ReadLine()); 
		int y = Convert.ToInt32(Console.ReadLine());
		for(int i = x; i<=y; i++)
		{
			if(i % 3 == 0 && i % 5 == 0)
			{
				Console.Write(" {0}",i);
			}
		}
		
	}
}