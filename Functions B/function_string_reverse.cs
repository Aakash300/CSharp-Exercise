/* Create a C# program that implements a function called InvertString receive receive a text by parameter and display them in reverse order. */

using System;
					
public class Function_string_reverse
{
	public static void Main()
	{

		string text = Console.ReadLine();
		string invertString = InvertString(text);
 
        Console.WriteLine(invertString);
	}
	
	public static string InvertString(string text)
	{
		string reverse = ""; // string reverse = string.Empty;
		for(int i = text.Length-1; i >=0; i--)
		{
			reverse+=text.Substring(i,1);
		}
		
		return reverse;
	}
}
