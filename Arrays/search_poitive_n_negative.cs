/* Create a C# program that asks the user for 10 real numbers and shows the arithmetic mean of the positive and negative numbers. */

using System;
					
public class search_poitive_n_negative
{
	public static void Main(string[] args)
    {
       int numbers = 10;
	   float[] list = new float[numbers];
	   float totalPositive = 0.0f, totalNegative = 0.0f;
       int countPositive = 0, countNegative = 0;
		for(int i = 0 ; i< numbers;i++)
		{
			list[i]= Convert.ToInt32(Console.ReadLine());
		}
		for(int i=0; i<numbers;i++)
		{
			if(list[i]>0)
			{
				totalPositive = totalPositive+list[i];
				countPositive++;
			}
			if(list[i]<0)
			{
				totalNegative = totalNegative+list[i];
				countNegative++;
			}
		}
		Console.WriteLine("Average numbers positives is {0}",totalPositive/countPositive);
		Console.WriteLine("Average numbers negatives is {0}",totalNegative/countNegative);
		
    }
}