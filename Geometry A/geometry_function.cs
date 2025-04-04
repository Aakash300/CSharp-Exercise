/* Create a program C# to draw the graphic of the function y=(x-4)² for a range of integer values of x requested from the user. */

using System;
public class geometry_function
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter x and y");
		int x1 = Convert.ToInt32(Console.ReadLine());
		int x2 = Convert.ToInt32(Console.ReadLine());
		int y ;
		
		for (int x = x1; x <= x2; x++)
        {
            y = (x-4)*(x-4);
            for (int j = 0; j < y; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
		
    }
}