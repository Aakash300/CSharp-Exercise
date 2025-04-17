/*Create a C# program that implements two methods to greet and say goodbye. The method of greeting has a parameter 'name' of text. 
Then you must run them from the main program.*/

using System;
					
public class Function_parameter
{
	public static void Main(string[] args)
    {
		Greetings("Akash");
     	Farewell();
    }
	
	public static void Greetings(string name)
	{
		Console.WriteLine("Hello {0} " ,name);
	}
	
	public static void Farewell()
	{
		Console.WriteLine("Good Bye!");
	}
	
}