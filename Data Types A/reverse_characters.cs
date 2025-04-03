// Write a program to ask the user for three letters and display them in reverse order.

using System;
public class reversing_characters
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter 3 characters");
        char  a = Convert.ToChar(Console.ReadLine());
		char  b = Convert.ToChar(Console.ReadLine());
		char  c = Convert.ToChar(Console.ReadLine());
		
		Console.WriteLine("{2} {1} {0}",a,b,c);
    }
}