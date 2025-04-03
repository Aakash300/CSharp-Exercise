// Write a program in C# that requests two integers from the user (x, y) and print the result of the division and the rest of the division on a new line.
using System;
public class DivisionandModulus
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
		int y = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("{0}", x/y);
		Console.WriteLine("{0}", x%y);
    }
}