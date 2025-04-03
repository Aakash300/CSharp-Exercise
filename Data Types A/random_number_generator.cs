/*Write a program in C# that asks the user for a number x and shows the result of his multiplication table from 1 to 10. */

using System;
public class random_number
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter range for random number");
        int r1 = int.Parse(Console.ReadLine());
		int r2 = Convert.ToInt32(Console.ReadLine());
		
		Random rnd = new Random();
		int num = rnd.Next(r1,r2+1);
		Console.WriteLine("Rnadom no : {0}",num);
    }
}