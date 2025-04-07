/*Create a C# program that asks the user for two integers (a, b) and check how many of them are positive.

Use a conditional operator nested in C#. */

using System;
					
public class ConditionalOperator_Nested
{
	public static void Main()
	{
		Console.WriteLine("Enter two value");
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		int operation = ((a>0)&&(b>0))?2:((a>0)||(b>0))?1:0;
		Console.WriteLine(operation);
	}
}