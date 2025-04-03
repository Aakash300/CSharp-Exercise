using System;
public class StoreUserInput
{
    public static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string x = Console.ReadLine();
        Console.WriteLine("Nice to meet you, " + x);
    }
}