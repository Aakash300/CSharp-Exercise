/* Write a program in C# that asks the user for the grades of 5 students divided into 2 groups of 5 students in each. 
   You must store them in a two-dimensional array and show the arithmetic average of each group of students. */

using System;
					
public class two_dimensional_array
{
	public static void Main(string[] args)
    {
       int totalByGroup = 5;
	   float[,] punctuation = new float [totalByGroup,totalByGroup];
	   float totalByGroup1 = 0.0f, totalByGroup2 = 0.0f;
		
		// Get puntuations
		for (int i =0 ; i<2;i++)
		{
			for( int j =0; j < totalByGroup;j++)
			{
				punctuation[i,j]=Convert.ToInt32(Console.ReadLine());
			}
		}
		
		// Calculate average group 1
		
		for( int i = 0; i<totalByGroup; i++)
		{
			totalByGroup1 += punctuation[0,i];
		}
	    Console.WriteLine("Average for group 1 is {0}", totalByGroup1 / totalByGroup);
		
		// Calculate average group 2
		
		for( int i = 0; i<totalByGroup; i++)
		{
			totalByGroup2 += punctuation[1,i];
		}
	    Console.WriteLine("Average for group 2 is {0}", totalByGroup2 / totalByGroup);
		
		
    }
}