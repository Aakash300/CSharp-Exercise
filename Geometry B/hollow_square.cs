/*Write a program in C# that asks for a symbol and a width that you will use to draw the hollow square of that width and height.

Use the symbol to draw the hollow square, the height will be the same as the width. */

using System;
					
public class hollow_square
{
	public static void Main()
	{
		Console.WriteLine("Enter symbol and width ");
		int symbol = Convert.ToInt32(Console.ReadLine());
		int width = Convert.ToInt32(Console.ReadLine());
			
		for( int i = 0; i< width;i++)
		{
			Console.Write(symbol);
		}
		Console.WriteLine();
		
		for(int i = 0; i< width-2;i++)
		{
			Console.Write(symbol);
			
			for(int j = 0 ; j< width-2;j++)
			{
				Console.Write(" ");
			}
			Console.WriteLine(symbol);
		}
		
		for(int i = 0; i< width;i++)
		{
			Console.Write(symbol);
		}
		Console.WriteLine();
			
	}
}