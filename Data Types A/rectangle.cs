/*Write a C# program that requests the width (x) and height (y) of a rectangle and calculate the perimeter, area and diagonal.

Perimeter= sum of the four sides.
Area= base x height.
Diagonal= Pythagorean theorem. */

using System;
public class rectangle
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter height and width");
        int height = Convert.ToInt32(Console.ReadLine());
		int width = Convert.ToInt32(Console.ReadLine());
		int perimeter = 2*height+2*width;
		int area = width*height;
		double diagonal = Math.Sqrt(height*height+width*width);
		Console.WriteLine("perimeter:{0}  area:{1}   diagonal:{2}",perimeter,area, diagonal);
    }
}