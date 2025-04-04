/*Write a program in C# that asks for a number (x) and a width to show a square of that width.

Use the number to paint the square. */

using System;
public class geometry_shape
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter a number and size of the square");
        int num = int.Parse(Console.ReadLine());
		int width = Convert.ToInt32(Console.ReadLine());
		
		for(int i =0; i<=width;i++)
		{	
			for( int j=0 ; j<=width;j++)
			{
				Console.Write(num);
			}
			
			Console.WriteLine();
		}
    }
}