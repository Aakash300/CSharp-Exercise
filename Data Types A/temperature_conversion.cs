/*Create a C# program to convert from degrees Celsius to Kelvin and Fahrenheit. Request the user the number of degrees celsius to convert them using the following conversion tables:

kelvin = celsius + 273
fahrenheit = celsius x 18 / 10 + 32  */

using System;
public class temperature_conversions
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter celcius");
        decimal celsius = Convert.ToDecimal(Console.ReadLine());
		decimal kelvin = celsius + 273;
		decimal fahrenheit = (celsius * 18) / 10 + 32 ;
		Console.WriteLine("kelvin:{0}  fahrenheit:{1}",kelvin, fahrenheit);
    }
}