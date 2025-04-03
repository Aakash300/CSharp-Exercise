/*Write a program in C# that asks the user for a number x and shows the result of his multiplication table from 1 to 10. */

using System;
public class multiplication_table
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter a no for multiplication table");
        int num = Convert.ToInt32(Console.ReadLine());
		for( int i = 1; i<=10;i++)
		{
        Console.WriteLine("{0} X {1} = {2}",num,i,num*i);
		}
    }
}