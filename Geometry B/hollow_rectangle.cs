/*Write a program in C# that asks the user for a symbol, a width and a height to draw a hollow rectangle with those dimensions.

Use the symbol to paint the hollow rectangle. */

using System;
					
public class hollow_rectangle
{
	public static void Main()
	{
		Console.WriteLine("Enter symbol, width and height");
		int symbol = Convert.ToInt32(Console.ReadLine());
		int width = Convert.ToInt32(Console.ReadLine());
		int height = Convert.ToInt32(Console.ReadLine());
			
		for(int i = 1; i<=height;i++)
		{
			for(int j =1 ; j<=width;j++)
			{
				if((i==1)||(i==height))
				{
					Console.Write(symbol);
				}
				else
				{
					if((j==1)||(j==width))
					{
						Console.Write(symbol);
					}
					else
					{
						Console.Write(" ");
					}
				}
			}
			Console.WriteLine();
		}
			
			
	}
}