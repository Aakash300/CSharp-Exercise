/* Write an access control in C# that asks the user for the username and password. Both must be integers and repeat until the login is 12 and the password is 1234 or up to a maximum of 3 attempts.

If the username and password are correct it shows Login successful, but Login failed. */

using System;
					
public class access_control
{
	public static void Main()
	{
		Console.WriteLine("Enter a username and password");
		int user, pass;
		int	attempt=0;
		do
		{
		user = Convert.ToInt32(Console.ReadLine()); 
		pass= Convert.ToInt32(Console.ReadLine());
		
		if(user!=12 && pass!=1234)
		{
			Console.WriteLine("Login failed");
		}
			attempt++;
		}
		while((user!= 12) && (pass != 1234) && (attempt!=3));
		
		if( user==12 && pass==1234)
		{
			Console.WriteLine("Login sucessful");
		}
		
		
	}
}