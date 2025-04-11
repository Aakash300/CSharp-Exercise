/* Create a C# program that asks the user for an integer (x) and displays the product of its prime factors.
 */

using System;
					
public class product_prime
{
	public static void Main()
	{
		Console.WriteLine("Enter two values");
		int x = Convert.ToInt32(Console.ReadLine());
		int divisor = 2;
		while(x>1)
		{
			while(x % divisor== 0)
			{
				Console.Write(divisor+"x");
				x = x / divisor; 
			}
			divisor++;
		}
		 Console.Write(1);
	}
}