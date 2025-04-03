// Write a program in C# that requests an integer x from the user and print the result of adding it to the square.

using System;
public class sum_sqaring
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("{0}x{0}= {1}",x,x*x);
    }
}