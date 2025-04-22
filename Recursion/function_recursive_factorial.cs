/* Create a C# program that implements a recursive function that receives a requested number from the user and returns the factorial of that number. 
You must calculate the factorial of the number using recursion. */

using System;
public class function_recursive_factorial
{
    public static void Main()
    {
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(Factorial(num1));
		Console.ReadLine();
	}
		
	public static int Factorial(int num1)
	{
		if(num1 == 0)
		{
			return 1;
		}
		else
		{
			return num1 * Factorial(num1 - 1);
		}
	}
}