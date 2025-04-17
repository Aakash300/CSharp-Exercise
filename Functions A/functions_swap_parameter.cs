/*Create a function named Swap to swap the values of two integer numbers, which are passed by reference.*/

using System;
					
public class Function_swap_parameter
{
	public static void Main(string[] args)
    {
		int x = Convert.ToInt32(Console.ReadLine());
		int y = Convert.ToInt32(Console.ReadLine());
		
		Swap(ref x, ref y);
        Console.WriteLine("{0} {1}", x, y);
    }
	
	public static void Swap(ref int x, ref int y)
	{
	    int swap = x;
        x = y;
        y = swap;
	}
}