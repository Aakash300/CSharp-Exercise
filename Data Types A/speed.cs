/*Create a program C# to ask the user for a distance in meters and the time taken (hours, minutes, seconds).

Display the speed, in meters per second, kilometers per hour and miles per hour.

1 mile = 1609 meters. */

using System;
public class rectangle
{
    public static void Main(string[] args)
    {
		Console.WriteLine("Enter distance in meter");
       	        float distance = float.Parse(Console.ReadLine());
		float hour = float.Parse(Console.ReadLine());
		float min = float.Parse(Console.ReadLine());
		float sec = float.Parse(Console.ReadLine());
		float timeBySeconds = (hour*3600) + (min*60) + sec;
        float mps = distance/timeBySeconds;
        float kph = (distance/1000.0f) / (timeBySeconds/3600.0f);
        float mph = kph/1.609f;
 
        Console.WriteLine("Speed in meters/sec is {0}", mps);
        Console.WriteLine("Speed in km/h is {0}", kph);
        Console.WriteLine("Speed in miles/h is {0}", mph);
    }
}