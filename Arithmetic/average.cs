// Write a C# program that calculates the arithmetic measurement of 4 factors entered by the user, one for each line.

using System;
public class NumbersAverage
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter 4 numbers:");
        int x = Convert.ToInt32(Console.ReadLine());
		int y = Convert.ToInt32(Console.ReadLine());
		int z = Convert.ToInt32(Console.ReadLine());
		int m = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Average of 4 numbers: {0}", (x+y+z+m)/4);

		
    }
}