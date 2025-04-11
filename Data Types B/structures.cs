/* Create a C# program that asks the user for their name and age. You must save them in a struct data structure and then greet the user using their name. */

using System;
					
public class structures
{
	public struct Person
	{
		public string Name;
		public int age;
	}
	
	public static void Main()
	{
		Person p = new Person();
		p.Name = Console.ReadLine();
		p.age = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Hello! {0}",p.Name);
	}
}