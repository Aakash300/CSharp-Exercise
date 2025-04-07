/* Create a program in C# which asks the user for two integer numbers and displays their multiplication, but not using the operator *. You must use consecutive sums. */

using System;
					
public class ProductOfNumber
{
	public static void Main()
	{
		Console.WriteLine("Enter any number:");
		int x = Convert.ToInt32(Console.ReadLine());
		int y = Convert.ToInt32(Console.ReadLine());
		
		int result = 0;
		int i =0;
		
		while(i<y)
		{
			result+=x;
			i++;
		}
		Console.WriteLine("{0}x{1}={2}",x,y,result);
	}
}