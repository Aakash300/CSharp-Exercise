/* Create a C# program that uses recursion to calculate a number in the series of Fibonacci.

In the Fibonacci series, the series begins with the numbers 0 and 1, from these, each term is the sum of the previous two. */

using System;
public class function_recursive_fibonacci
{
    public static void Main()
    {
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(Fibonacci(num1));
		Console.ReadLine();
	}
		
	public static int Fibonacci(int num1)
	{
		if(num1 == 1 || num1 == 2)
		{
			return 1;
		}
		else
		{
			return Fibonacci(num1 - 1)+ Fibonacci(num1 - 2);
		}
	}
}