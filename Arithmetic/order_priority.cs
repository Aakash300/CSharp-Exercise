/* Create a C# program that requests an integer x from the user and print the result of the following operations:

1. -6 + x * 5
2. (13-2) * x
3. (x + -2) * (20 / 10)
4. (12 + x) / (5 - 4) */

using System;
public class MultipleOperations
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine(-6 + x * 5);
		Console.WriteLine((13-2) * x);
		Console.WriteLine((x + -2) * (20 / 10));
		Console.WriteLine((12 + x) / (5 - 4));
		
    }
}