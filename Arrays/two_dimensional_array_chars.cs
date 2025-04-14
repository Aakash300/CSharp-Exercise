/* Create a C# program that declares a two-dimensional character array of 20 rows by 70 columns and stores the letter 'X' to draw on the screen. */

using System;
					
public class two_dimensional_array_chars
{
	public static void Main(string[] args)
    {
	  int rows = 20;
	  int columns = 70;
      char[,] chars = new char[rows,columns];
	  char letter = 'X';
		
	  // filling char	
	  for(int i = 0 ; i< rows;i++)
	  {
		  for(int j =0; j < columns; j++)
		  {
			  chars[i,j] = letter;
		  }
	  }
		
		// Showing char
		
		for(int i = 0; i<rows;i++)
		{
			for(int j= 0; j<columns;j++)
			{
				Console.Write(letter);
			}
			Console.WriteLine();
		}
		
		
    }
}