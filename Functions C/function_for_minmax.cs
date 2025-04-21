/*Create a C# program that implements a function called FindMinMax that receives three parameters, an array of real numbers and two real numbers.

You must request 5 real numbers from the user to create the data array.

The function will calculate the minimum and maximum values ??of the array of real numbers. Send the parameters by reference.*/
using System;
public class function_for_minmax
{
    public static void Main()
    {
		int total = 5;
		float[] data = new float[total];
		
		for(int i = 0; i < total; i++)
		{
			data[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		float min = 0.0f;
        float max = 0.0f;
 
        FindMinMax(ref data, ref min, ref max);
 
        Console.WriteLine("The minimum value is {0}",min);
        Console.WriteLine("The maximum value is {0}",max);
	}
		
	public static void FindMinMax(ref float[] data, ref float min, ref float max)
	{
			 max = data[0];
       		 min = data[0];
		
		for(int i = 0; i < data.Length; i++)
		{
			if(data[i]>max)
			{
				max=data[i];
			}
			if(data[i]<min)
			{
				min = data[i];
			}
		}
	}
		
	
}