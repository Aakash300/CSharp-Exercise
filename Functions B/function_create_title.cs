/* Create a C# program that implements a function called WriteTitle that writes a text centered on the screen, in capital letters, with additional spaces and with one line above and another below. 
Look at the output to see the format. */

using System;
					
public class Function_create_title
{
	public static void Main()
	{
		string text = Console.ReadLine();
 
        WriteTitle(text);
	}
	
	public static void WriteTitle(string text)
	{
		int numOfSpaces = (80 - text.Length * 2) / 2;
 
        text = text.ToUpper();
		
		for (int i = 0; i < numOfSpaces; i++)
        {
            Console.Write(" ");
        }
		
		for (int i = 0; i < text.Length * 2 - 1; i++)
        {
            Console.Write("-");
        }
 
        Console.WriteLine();

		for (int i = 0; i < numOfSpaces; i++)
        {
            Console.Write(" ");
        }
		
		for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[i] + " ");
        }
		 
		Console.WriteLine();
 
        for (int i = 0; i < numOfSpaces; i++)
        {
            Console.Write(" ");
        }
 
        for (int i = 0; i < text.Length * 2 - 1; i++)
        {
            Console.Write("-");
        }
 
        Console.WriteLine();
	}
}