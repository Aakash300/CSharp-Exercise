// Create a C# program that asks the user for two numbers (x, y) and shows the result of their division.
using System;
public class Dividing_by_Zero
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
		int y = Convert.ToInt32(Console.ReadLine());
		
		try
		{
			Console.WriteLine("{0}/{1}={2}",x,y,x/y);
		}
		catch(DivideByZeroException)
		{
			Console.WriteLine("Cannot be divided by zero");
		}
		
    }
}