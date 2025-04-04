/* Write a program in C# that requests a number x and then displays a rectangle 3 columns wide and 5 rows high using that digit. */

using System;
public class geometry_rectangle
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter a column size for rectangle");
		int column = Convert.ToInt32(Console.ReadLine());
		
		for(int i =0; i < 5; i++)
		{	
			for( int j=0 ; j < column; j++)
			{
				Console.Write(column);
			}
			
			Console.WriteLine();
		}
    }
}