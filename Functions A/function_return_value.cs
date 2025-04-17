/*Create a C# program that implements a function called Add that returns the sum of two whole numbers passed by parameter.
Then you must execute the function from the Main of the program.*/

using System;
					
public class Function_return_value
{
	public static void Main(string[] args)
    {
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		
		int sum = Sum(a,b);
		Console.WriteLine(sum);
    }
	
	public static int Sum(int a, int b)
	{
		return a + b;
	}
	
	
}