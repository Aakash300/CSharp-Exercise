/* Create a C # program that uses an array of struct to store a car record. You will first need to create a data structure called Car with two public properties:

Model: string
YearOfProduction: int
Now request for example 3 cars from the user and save them in the structs array. Lastly, order the cars by their year of manufacture, the oldest first. */

using System;

public struct Car
{
	public string Model;
	public int YearOfProduction;
}
					
public class array_of_struct
{
	public static void Main(string[] args)
    {
	 int total = 3;
	 Car[] cars = new Car [total];
		
	for( int i = 0; i< total ; i++)
	{
		cars[i] = new Car()
		{
			Model = Console.ReadLine(),
			YearOfProduction = Convert.ToInt32(Console.ReadLine())
		};
	}
		
		// Sorting
		
		for (int i = 0; i< total ;i++)
		{
			for(int j = i+1; j< total; j++)
			{
				if(cars[i].YearOfProduction > cars[j].YearOfProduction)
				{
					var aux = cars[i];
					cars[i] = cars[j];
					cars[j] = aux;
				}
			}
		}
		
		// Display
		for (int i =0 ; i<total; i++)
		{
			var car = cars[i];
			Console.WriteLine("Models: "+car.Model+ " , " + "Year Of Production: "+ car.YearOfProduction);
		}
		
		
    }
}