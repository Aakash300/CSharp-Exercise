/* Create a C# program that requests a string from the user and implements a recursive function to reverse a string of characters. */

using System;
public class function_recursive_string_rev
{
    public static void Main()
    {
		string text = Console.ReadLine();
		Console.WriteLine(Reverse(text));
		Console.ReadLine();
	}
		
	public static string Reverse(string text)
	{
		if(text.Length<=1)
		{
			return text;
		}
		
		char firstLetter = text[0];
		string rest = text.Substring(1);
		
		return Reverse(rest) + firstLetter;
	}
}