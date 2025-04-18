/* Create a program in C# that serves to generate mathematical statistics. The program must store a total of 1000 numerical values with decimals in an array of data and must also have a menu with different options that the user can select. It will run until the user presses the exit option. The program menu must include the following options (1-5):

1. Add
2. Show
3. Search
4. Statistics
5. Exit
Add
In the option to add the user, you can add new values in the data array. Be careful not to exceed 1000 values in the data array.

Show
The view option will show the list of values in a line. There may not be any values yet.
Search
To search for values, you must request a real number from the user and show whether or not it exists in the program. There may not be any values yet.

Statistics
This option will show the user a summary of statistics of the data array values, it must include:

Total stored values
The total sum of values
Average
Maximum value and minimum value
Finally, you should consider when the user enters a different option from 1 to 5. */

using System;
					
public class Statistics
{
	public static void Main(string[] args)
    {
	 int total = 1000;
	 float[] numbers = new float[total];
	 int count = 0;
	 
	 float maxValue = float.MinValue;
	 float minValue = float.MaxValue;
	 float totalValues = 0.0f;
		
	 int option=0;
		
	 do
	 {
		    Console.WriteLine("1. Add");
            Console.WriteLine("2. Show");
            Console.WriteLine("3. Search");
            Console.WriteLine("4. Statistics");
            Console.WriteLine("5. Exit");
 
            Console.WriteLine();
            Console.Write("Enter a option (1-5): ");
            option = Convert.ToInt32(Console.ReadLine());

		 switch(option)
		 {
			 case 1: //Add
				 if(count < total)
				 {
					 numbers[count] = Convert.ToInt32(Console.ReadLine());
					 if(maxValue < numbers[count])
					 {
						 maxValue = numbers[count];
					 }
					 if(minValue > numbers[count])
					 {
						 minValue = numbers[count];
					 }
					 totalValues += numbers[count];
					 count++;
				 }
				 else
                    {
                        Console.WriteLine("The database is full");
                    }
				 break;
				 
			 case 2: //show
				 
				 if(count>0)
				 {
					 for(int i = 0; i < count;i++)
					 {
						  Console.Write("{0} ", numbers[i]);
					 }
					 Console.WriteLine();
				 }
				 else
                    {
                        Console.WriteLine("No data available");
                    }
				 break;
				 
			 case 3: // Search
				 if(count > 0)
				 {
					 float searchNumber = Convert.ToSingle(Console.ReadLine());
					 bool foundNumber = false;
					 for(int i = 0; i < count ; i++)
					 {
						 if(numbers[i] == searchNumber)
						 {
							 foundNumber = true;
						 }
					 }
					 if (foundNumber)
                      {
                          Console.WriteLine("Number {0} found", searchNumber);
                      }
                     else
                       {
                          Console.WriteLine("Not found");
                       }
				 }
			   else
               {
                  Console.WriteLine("No data available");
                }

				 break;
				 
			 case 4: // Statistics
				  if (count > 0)
                    {
                        Console.WriteLine("Total data: {0}", count);
                        Console.WriteLine("Sum: {0}", totalValues);
                        Console.WriteLine("Average: {0}", totalValues / count);
                        Console.WriteLine("Min value: {0}", minValue);
                        Console.WriteLine("Max value: {0}", maxValue);
                    }
                    else
                    {
                        Console.WriteLine("No data available");
                    }
				 break;
				 
                default:
                    Console.WriteLine("Valid options (1-5)");
                    break;
		 }
	 }
	 while(option!=5);
    }
}