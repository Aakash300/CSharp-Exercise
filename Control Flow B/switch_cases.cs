 Create a C# program that calculates a student's grade from an integer. Ask the user for a number (x) and answer the following

10 - A+
9 - A
7,8 - B
6 - C
5 - E
0,4 - F
Use the switch, break and default instruction of C#. 

using System;
					
public class switch_cases
{
	public static void Main()
	{
		Console.WriteLine(Enter a grade between 1 to 10);
		int score = Convert.ToInt32(Console.ReadLine()); 
		switch(score)
		{
			case 10
				Console.WriteLine(A+);
				break;
			case 9
				Console.WriteLine(A);
				break;
			case 8
			case 7
				Console.WriteLine(B);
				break;
			case 6
				Console.WriteLine(C);
				break;
			case 5
				Console.WriteLine(E);
				break;
			default
				Console.WriteLine(F);
				break;
		}
	}
}