/*Create a C# program that implements a recursive function to check if a string is a palindrome or not. 
A palindrome are strings that can be read equally from right to left, such as 'radar'. */

using System;
public class function_recursive_palindrome
{
    public static void Main()
    {
		string text = Console.ReadLine();
		Console.WriteLine(Palindrome(text));
		Console.ReadLine();
	}
		
	public static bool Palindrome(string text)
	{
		if(text.Length<=1)
		{
			return true;
		}
		
		else
		{
			if( text[0] != text[text.Length - 1 ] )
			{
				return false;
			}
			else
			{
				return Palindrome(text.Substring(1,text.Length - 2));
			}
		}
	}
}