/*Create a C# program that asks the user for text and draws a pyramid on the screen. */

using System;
					
public class draw_pyramid
{
	public static void Main()
	{
		Console.WriteLine("Enter text");
		string text = Console.ReadLine();
		
		if (text.Length % 2 == 0)
        {
            text += " ";
        }
 
        int position = text.Length / 2;
        int rows = text.Length / 2 + 1;
        int amount = 1;
 
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < position; j++)
            { 
                Console.Write(" ");
            }
 
            Console.WriteLine(text.Substring(position, amount));
            position--;
            amount += 2;
        }
	}
}