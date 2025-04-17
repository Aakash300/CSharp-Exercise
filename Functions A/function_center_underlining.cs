/*Create a program in C# that implements a function called WriteCenteredUnderline that receives as a parameter a text requested from the user. 
Then show the text centered and underlined using the '-' character on the screen, assuming we have 80 spaces wide.*/

using System;
					
public class Function_center_underlining
{
	public static void Main(string[] args)
    {
		string text = Console.ReadLine();
        WriteCenteredUnderline(text);
    }
	
	public static void WriteCenteredUnderline(string text)
	{
		int countSpaces = (80 - text.Length) / 2;
        int i = 0;
 
        for (; i < countSpaces; i++)
        { 
            Console.Write(" ");
        }
 
        Console.WriteLine(text);
 
        for (i = 0; i < countSpaces; i++)
        { 
            Console.Write(" ");
        }
 
        for (i = 0; i < text.Length; i++)
        {
            Console.Write("_");
        }
		
	}
}