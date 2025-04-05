/* Create a program in C# that requests a number (x) and displays 10*x. Must be repeated until the user enters 0. */

using System;
public class While_loop
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter a any number and '0' to exit ");
		int x1 = int.Parse(Console.ReadLine());
		while(x1!=0)
		{
			Console.WriteLine("{0}",x1*10);
			x1 = int.Parse(Console.ReadLine());
		}
		
    }
}