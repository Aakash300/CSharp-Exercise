/* Write a C# program that shows the letters of the alphabet in capital letters using only a for loop and char variables. */

using System;
					
public class alphabets
{
	public static void Main()
	{
		for (char c = 'A'; c<='Z';c++)
		{
			Console.Write(c+ " ");
		}
	}
}