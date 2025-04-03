// Write a C# program to ask the user for three numbers (a, b, c) and display the result of (a+b)*c and the result of a * c + b*c.

using System;
public class Equivalent_operation
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter 3 numbers:");
        int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		int c = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("(a+b)*c: {0}", (a+b)*c);
		Console.WriteLine("a*c + b*c: {0}", a * c + b*c);

		
    }
}