/*Create a C# program that implements a function to check if a string is a palindrome or not.
A palindrome are strings that can be read equally from right to left, such as 'radar'.*/
using System;
public class function_palindrome
{
    public static void Main()
    {
		string text = Console.ReadLine();
		Console.WriteLine(Palindrome(text));
	}
		
	public static bool Palindrome(string text)
	{
		text = text.ToUpper();
		int j = text.Length-1;
		
		for(int i =0; i < j ; i++)
		{
			if(text[i]!=text[j])
			{
				return false;
			}	
			j--;
		}
		return true;
	}
}