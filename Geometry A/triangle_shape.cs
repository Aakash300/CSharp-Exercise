/* Write a program in C# that asks for a symbol and a width to paint a triangle of that width and height using that number to draw it. */

using System;
public class geometry_rectangle
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter a triangle width and no");
		int num = Convert.ToInt32(Console.ReadLine());
		int width = Convert.ToInt32(Console.ReadLine());
		int height = width; // takes the value for example 5 and does not change.
		
		for(int i =0; i < height; i++)  // The value 5 can be used here without applying decrement operator.
		{	
			for( int j=0 ; j < width; j++)
			{
				Console.Write(num);
			}
			
			Console.WriteLine();
			width--;
		}
    }
}