/* Create a program in C# that serves to search an array of integer values. To do this, follow these steps:

Get the quantity (x) of values from the array of integers
Prepare an array of integers with the previous amount
Get the number (and) to look for in the array of integers
Show whether the number (y) exists in the array of integers or not
Repeat until the end text is entered */

using System;
					
public class search_array_integers
{
	public static void Main()
	{
		Console.WriteLine("Enter intergers");
		int x = Convert.ToInt32(Console.ReadLine());
		int[] list = new int[x];
		for(int i = 0; i < x; i++)
		{
			list[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		string y ;
		
		do
		{
			y = Console.ReadLine();
			
			if (y != "end")
            {
				int y_to_int = Convert.ToInt32(y);
			
			if(Array.BinarySearch(list,y_to_int)>=0)
			{
				Console.WriteLine("the number {0} exists", y);
			}
			else
			{
				Console.WriteLine("the number {0} does not exists", y);
			}
			}
		}
		while(y!="end");
		
	}
}