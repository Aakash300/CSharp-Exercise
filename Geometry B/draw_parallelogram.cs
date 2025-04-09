/*Create a C# program to draw a parallelogram, with the width, height and character requested from the user. */

using System;
					
public class draw_parllelogram
{
	public static void Main()
	{
		Console.WriteLine("Enter width,height and character");
		int width = Convert.ToInt32(Console.ReadLine());
		int height = Convert.ToInt32(Console.ReadLine());
		char character = char.Parse(Console.ReadLine());
			
		for(int i = 0;i<height;i++)
		{
			for(int j =0; j<width; j++)
			{
				Console.Write(character);
			}
		
			Console.WriteLine();
		
			for (int c = 0 ; c<=i;c++)
			{
				Console.Write(" ");
			}
		}	
	}
}