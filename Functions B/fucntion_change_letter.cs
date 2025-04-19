/* Create a C# program that implements a function called ChangeLetter that receives as a parameter a text, 
a position (based on 0) and a letter requested from the user. You must modify the character of the text and display the new text on the screen. */

using System;
					
public class Function_change_letter
{
	public static void Main()
	{
		String text = Console.ReadLine();
		int position = Convert.ToInt32(Console.ReadLine());
		char letter = Convert.ToChar(Console.ReadLine());
		
		 Console.WriteLine(ChangeLetter(text,position,letter));
	}
	
	public static string ChangeLetter(string text, int position, char letter)
	{
		text = text.Remove(position,1);
		text = text.Insert(position,letter.ToString());
		return text;
	}
}
