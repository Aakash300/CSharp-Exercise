/* Write a program in C# that asks for numbers and shows their sum. Request numbers until the user enters 0 and when the program ends show Finished. */

using System;
					
public class sum_of_infinite
{
	public static void Main()
	{
		Console.WriteLine("Enter any number and '0' to exit");
		int x = Convert.ToInt32(Console.ReadLine());
		int sum = 0;
		while(x!=0)
		{
			sum= sum + x;
			Console.WriteLine("{0}",sum);
			x = Convert.ToInt32(Console.ReadLine());
		}
		if(x==0)
		{
			Console.WriteLine("Finished");
		}
	}
}