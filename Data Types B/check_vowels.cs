/* Create a C# program that asks the user for a letter (x) and check if it is a vowel or other symbol.

Display on the Vocal screen or Other symbol. */

using System;
					
public class Check_vowels
{
	public static void Main()
	{
		Console.WriteLine("Enter a letter to check for  vowels");
		string c = Console.ReadLine();
		c = c.ToLower();
		switch(c)
		{
			case "a":
				Console.WriteLine("It is a Vowel");
				break;
			case "e":
			case "i":
			case "o":
			case "u":
				Console.WriteLine("It is a Vowel");
				break;
			default:
				Console.WriteLine("It is not a Vowel");
				break;
		}
	}
}