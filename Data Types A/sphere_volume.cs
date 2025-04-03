/*Create a program in C# for calculate the surface and volume of a sphere, given its radius.

surface= 4 * pi * radius squared
volume= 4 / 3 * pi * radius cubed */

using System;
public class Sphere
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter radius:");
		float pi  = 3.1415926535f;
        float radius = Convert.ToSingle(Console.ReadLine());
		Console.WriteLine("Surface: {0}",4 * pi * radius * radius);
		Console.WriteLine("Volume: {0}",(4 / 3 ) * pi * radius * radius * radius);

		
    }
}