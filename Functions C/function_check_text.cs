/*Create a C# program that implements a function called IsAlphabetic that receives a text parameter from the user and
check if the text has alphabetic characters from 'a' to 'z' including upper and lower case letters.*/

using System;
					
public class Function_check_text
{
	public static void Main()
	{
		string text = Console.ReadLine();
        Console.WriteLine(IsAlphabetic(text));
	}
	
	public static bool IsAlphabetic(string text)
	{
		text = text.ToUpper();
		for(int i = 0; i < text.Length; i++)
		{
			if((text[i] < 'A' || text[i] > 'Z'))
			{
				return false;
			}
		}
		return true;
	}
}