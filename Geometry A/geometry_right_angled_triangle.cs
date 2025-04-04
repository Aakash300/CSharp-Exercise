/* Write a program in C# that asks the user for a string and displays a right-aligned triangle. */

using System;
public class geometry_right_angled_triangle
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter a text");
		string name = Console.ReadLine();
		int j = 1;

		for(int i = name.Length-1; i >=0; i--)  
		{				
			Console.WriteLine(name.Substring(i, j));
			j++;
		}
    }
}