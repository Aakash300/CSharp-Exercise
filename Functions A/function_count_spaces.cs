/*Create a program in C# that implements a function called CountSpaces that receives as a parameter a text requested from the user. 
  Then show the total spaces that the text has.*/

using System;
					
public class Function_count_spaces
{
	public static void Main(string[] args)
    {
		string text = Console.ReadLine();
		int countSpaces = CountSpaces(text);
		Console.WriteLine(countSpaces);
    }
	
	public static int CountSpaces(string text)
	{
		int count = 0;
		string letter;
		
		for(int i = 0; i < text.Length;i++)
		{
			letter = text.Substring(i,1);
			
			if(letter==" ")
			{
				count++;
			}
		}
	
		return count;
	}
}