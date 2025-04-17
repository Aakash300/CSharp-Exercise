/*Create a function named Double to calculate the double of an integer number, and modify the data passed as an argument. 
   It must be a void function and you must use refererence parameters.*/

using System;
					
public class Function_calculate_double
{
	public static void Main(string[] args)
    {
		int numbers = Convert.ToInt32(Console.ReadLine());
		Double(ref numbers);
        Console.WriteLine(numbers);
    }
	
	public static void Double(ref int numbers)
	{
	   numbers+=numbers;
	}
}