// Write a program in C# that multiplies by three factors. Ask the user for three numbers and show the result of multiplying them.
using System;
public class Multiplying_numbers
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
		int y = Convert.ToInt32(Console.ReadLine());
		int z = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("{0}",x*y*z);
    }
}