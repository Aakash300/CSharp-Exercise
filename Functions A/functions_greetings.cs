/*Create a C# program that implements two methods to greet and say goodbye. Then you must run them from the Main of the program.*/

using System;
					
public class Function_greetings
{
	public static void Main(string[] args)
    {
		Greetings();
     	Farewell();
    }
	
	public static void Greetings()
	{
		Console.WriteLine("Hello");
	}
	
	public static void Farewell()
	{
		Console.WriteLine("Good Bye!");
	}
	
}