/* Create a C# program that shows hexadecimal numbers from 0 to 255. In 16 rows with 16 numbers in each.
 */

using System;
					
public class hexa_numbers
{
	public static void Main()
	{
		for(int i = 0; i<=255;i++)
		{
			if(i<16)
			{
				Console.Write("0");
			}
			Console.Write("{0} ",Convert.ToString(i,16));
			
			if(i % 16==15)
			{
				Console.WriteLine();
			}
		}
		
		
		
	}
}