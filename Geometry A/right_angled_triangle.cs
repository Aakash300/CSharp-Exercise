/* Write a program in C # that requests a width and shows a northeast triangle.

Use the * character to paint the triangle. */

using System;
public class geometry_rectangle
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter a triangle width and no");
		int num = Convert.ToInt32(Console.ReadLine());
		int count = num;
		int width = 0;
		
		for(int i =0; i < count; i++)  // The value 5 can be used here without applying decrement operator.
		{	
			for(int k =0; k < width; k++)
			{
				Console.Write(" ");
			}
			
			for( int j=0 ; j < num; j++)
			{
				Console.Write("*");
			}
			
			Console.WriteLine();
			num--;
			width++;
		}
    }
}