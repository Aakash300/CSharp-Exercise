/* Create a program in C# that implements a function called SearchGreatestValue that receives as an parameter an array of 5 real numbers requested from the user. 
You must obtain and display the largest of those numbers. */

using System;
					
public class Function_search_greatest
{
	public static void Main()
	{
		int total = 5;
		float[] numbers = new float[total];
		for(int i = 0; i< total;i++)
		{
			numbers[i] = Convert.ToSingle(Console.ReadLine());
		}
		float max = SearchGreatestValue(numbers);
        Console.WriteLine(max);
	}
	
	public static float SearchGreatestValue(float[] numbers)
	{
		float max = -99999999.00f;
		
		for(int i = 0; i < numbers.Length;i++)
		{
			if(i==0)
			{
				max = numbers[i];
			}
			else
			{
				max = max < numbers[i] ? numbers[i]:max;
			}
		}
		
		return max;
	}
}