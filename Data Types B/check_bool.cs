/* Create a C# program that uses the conditional operator to assign value to a boolean variable. You must assign true if two numbers entered by the user (x, y) are even and false if any of them is odd.

Finally, it shows the value of the variable on the screen.
 */

using System;
					
public class Check_boolean
{
	public static void Main()
	{
		Console.WriteLine("Enter two values");
		int x = Convert.ToInt32(Console.ReadLine());
		int y = Convert.ToInt32(Console.ReadLine());
		bool both = ((x % 2 ==0 && y % 2 ==0))? true:false;
		Console.WriteLine(both);

	}
}