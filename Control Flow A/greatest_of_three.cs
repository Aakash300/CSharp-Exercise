/* Write a program in C # that asks for three numbers (x, y, z) and display the greatest one. */

using System;
public class GreatestOfThree
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter a 3 numbers to find the greatest. ");
		int x1 = Convert.ToInt32(Console.ReadLine());
		int x2 = Convert.ToInt32(Console.ReadLine());
		int x3 = Convert.ToInt32(Console.ReadLine());
		if(x1 > x2 & x1 > x3)
		{
			Console.WriteLine("{0} is the greatest",x1);
		}
		else if (x2 > x1 & x2 > x3)
		{
			Console.WriteLine("{0} is the greatest",x2);
		}
		else if (x3> x1 & x3 > x2)
		{
			Console.WriteLine("{0} is the greatest",x3);
		}
		else
		{
			Console.WriteLine("All the numbers are equal.");
		}
		
    }
}