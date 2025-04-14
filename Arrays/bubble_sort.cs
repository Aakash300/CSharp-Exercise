/* Create a C# program that requests 10 integers from the user and orders them by implementing the bubble sort algorithm. */

using System;
					
public class bubble_sort
{
	public static void Main(string[] args)
    {
       int total = 10;
	   int[] list = new int[total];
		
		for(int i = 0; i<total; i++)
		{
			list[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		// Bubble Sort
		
		for( int i =0 ; i< total -1;i++)
		{
			for(int j = i+1; j<total;j++)
			{
				if(list[i]>list[j])
				{
					int aux = list[i];
					list[i]= list[j];
					list[j] = aux;
				}
			}
		}
		
		foreach(int n in list)
		{
			Console.Write("{0} ",n);
		}
		
    }
}