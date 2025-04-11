/* Create a program in C# that asks the user for an integer (x) and displays it in hexadecimal and binary.

Must be repeated until the user enters a 0.
 */

using System;
					
public class Converting_hexa_binary
{
	public static void Main()
	{
		int x;
		
		do
		{
			x = Convert.ToInt32(Console.ReadLine());
			
			if(x!=0)
			{
				Console.WriteLine(Convert.ToString(x,16));
				Console.WriteLine(Convert.ToString(x,2));
			}
		}
		while(x!=0);
	}
}