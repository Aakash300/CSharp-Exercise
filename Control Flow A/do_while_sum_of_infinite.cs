/* Write a program in C# that asks for numbers and shows their sum. Request numbers until the user enters 0 and when the program ends show Finished.*/

using System;
					
public class sum_of_infinite
{
	public static void Main()
	{
		Console.WriteLine("Enter any number and '0' to exit");
		int x;
        int sum = 0;
 
        do
        {
            x = Convert.ToInt32(Console.ReadLine());
            sum = x + sum;
 
            if (x != 0)
                Console.WriteLine(sum);
        }
        while (x != 0);
 
        Console.WriteLine("Finished");

		
	}
}