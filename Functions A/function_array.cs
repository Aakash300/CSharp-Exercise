/*Create a C# program that asks the user for 5 integers to store them in an array of integers. 
Then you must implement a function called Add that accepts that parameter an array of integers. Finally show the result on the screen.*/

using System;
					
public class Function_array
{
	public static void Main(string[] args)
    {
		int total =5;
		int[] numbers = new int[total];
		
		for(int i =0; i<total;i++)
		{
			numbers[i]= Convert.ToInt32(Console.ReadLine());
		}
		
		int sum = Sum(numbers);
		Console.WriteLine(sum);
    }
	
	public static int Sum(int[] numbers)
	{
		int sum = 0;
		for(int i=0;i<numbers.Length;i++)
		{
			sum+=numbers[i];
		}
		return sum;
	}
}