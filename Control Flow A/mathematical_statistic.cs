/* Create a C# program that prompts the user for 5 integers and displays the following mathematical statistics on the screen:

The sum of the 5 numbers
The arithmetic mean
The maximum number
The minimum number*/

using System;
					
public class mathematical_statistic
{
	public static void Main()
	{
		Console.WriteLine("Enter 5 integers to find the sum, mean, min and max");
		int total = 5;
		int[] numbers = new int[total];
		
		for(int i = 0 ; i < total; i++)
		{
			numbers[i] = int.Parse(Console.ReadLine());
		} 
		
		int sum = 0,
			average = 0,
			max = int.MinValue,
			min = int.MaxValue;
		
		for( int i = 0;  i < total;i++)
		{
			int num = numbers[i];
			sum += num;
			
			if(num> max)
			{
				max= num;
			}
			if( num<min)
			{
				min = num;
			}
		}
		
		average = sum / total;
 
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Max: " + max);
        Console.WriteLine("Min: " + min);
	}
}