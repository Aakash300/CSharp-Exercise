/* Write a program in C# that asks the user for two numbers and shows the division and the rest of the division. Notify if 0 is entered and end if 0 is entered in both*/

using System;
					
public class infinite_division
{
	public static void Main()
	{
		Console.WriteLine("Enter two numbers for division");
		int x1, x2;
		do
		{
		x1 = Convert.ToInt32(Console.ReadLine()); 
		x2= Convert.ToInt32(Console.ReadLine());
		
		if(x1!=0 && x2!=0)
		{
			Console.WriteLine("The division is {0}",x1/x2);
			Console.WriteLine("The rest is {0}",x1%x2);
		}
		else if (x1==0 && x2!=0)
		{
			Console.WriteLine("You cannot divide by 0");
		}
		else if (x1!=0 && x2==0)
		{
			Console.WriteLine("You cannot divide by 0");
		}
		
		}
		while((x1!= 0) || (x2 != 0));
		Console.WriteLine("Goodbye!");
				
	}
}