/*Create a C# program that implements a function called IsNumber that receives a text parameter from the user and check if the text is a number or not.*/

using System;
					
public class Function_check_numbers
{
	public static void Main()
	{
		string text = Console.ReadLine();
        Console.WriteLine(IsNumber(text));
	}
	
	public static bool IsNumber(string text)
	{
		for (int i = 0; i < text.Length; i++)
        {
            if ((text[i] < '0') || (text[i] > '9'))
            {
                return false;
            }
        }
		return true;
	}
	
}