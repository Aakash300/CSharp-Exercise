/*Create a C# program that simulates a supermarket cash register to return a purchase change. Request the total amount of money you have in the cash register (x) and an integer with the purchase value (y).

You must use 100, 50, 20, 10, 5, 2, or 1 bills and return the change using the larger bills first. */

using System;
					
public class supermarkt_change
{
	public static void Main()
	{
		Console.WriteLine("Enter total amount of money in cash register and purchase value");
		int register = Convert.ToInt32(Console.ReadLine());
		int purchase_val = Convert.ToInt32(Console.ReadLine());
		int change = register - purchase_val;
		
		while(change >=50)
		{
			Console.Write("50 ");
			change-=50;
		}
		while(change >=20)
		{
			Console.Write("20 ");
			change-=20;
		}
		while(change >=10)
		{
			Console.Write("10 ");
			change-=10;
		}
		while(change >=5)
		{
			Console.Write("5 ");
			change-=5;
		}
		while(change >=2)
		{
			Console.Write("2 ");
			change-=2;
		}
		while(change >=1)
		{
			Console.Write("1 ");
			change-=1;
		}
		
	

	}
}