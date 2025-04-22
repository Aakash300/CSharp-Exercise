/*Create a C# program that implements a recursive function called "Multiply" that receives two whole numbers
requested from the user and returns the result of its multiplication.*/

using System;
public class function_numbers_multiplication
{
    public static void Main()
    {
		int num1 = Convert.ToInt32(Console.ReadLine());
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine(Multiply(num1,num2));
	}
		
	public static int Multiply(int num1,int num2)
	{
		if(num2 == 0)
		{
			return 0;
		}
		else
		{
			return num1 + Multiply(num1,num2 - 1);
		}
	}
}