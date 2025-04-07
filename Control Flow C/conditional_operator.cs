Create a C# program which asks the user for two numbers and answers, using the conditional operator (), the following

If the first number is positive
If the second number is positive
If they are both positive 

using System;
					
public class ConditionalOperator
{
	public static void Main()
	{
		Console.WriteLine(Enter two value);
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(a0  A is a positiveA is not positive);
		Console.WriteLine(b0  B is a positiveB is not positive);
		Console.WriteLine((a0) && (b0)  Both are positiveNot both are positive);
	}
}