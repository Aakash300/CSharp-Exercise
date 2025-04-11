/* Create a C# program that asks the user for a text (x) and converts to check if the text is a number or not.
 */

using System;
					
public class Check_text
{
	public static void Main()
	{
		Console.WriteLine("Enter a text");
		string c = Console.ReadLine();
		try
		{
			Convert.ToInt32(c);
			Console.WriteLine("It's a number");
		}
		catch
		{
			Console.WriteLine("It is not a number");	
		}
	}
}