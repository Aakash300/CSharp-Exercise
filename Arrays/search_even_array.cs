/* Write a program in C# that asks the user for 10 integers to store them in an array of integers and show only even integers. */

using System;
					
public class search_even_array
{
	public static void Main(string[] args)
    {
       int total = 10;
	   int[] list = new int[total];
		
		for(int i =0; i<total; i++)
		{
			list[i]=Convert.ToInt32(Console.ReadLine());
		}
		
		for(int i =0; i<total;i++)
		{
			if(list[i]%2==0)
			{
				Console.Write("{0} ",list[i]);
			}
		}
		
    }
}