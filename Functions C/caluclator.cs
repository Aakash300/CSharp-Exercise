using System;

class MainParametersCalculator
{
    public static void Main(string[] args)
    {
        int num1, num2;
        char operation;

        // If not enough arguments, ask the user instead
        if (args.Length != 3)
        {
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, x, /): ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            num1 = Convert.ToInt32(args[0]);
            operation = Convert.ToChar(args[1]);
            num2 = Convert.ToInt32(args[2]);
        }

        switch (operation)
        {
            case '+':
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;
            case '-':
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;
            case 'x':
            case 'X':
            case '*':
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;
            case '/':
                if (num2 == 0)
                    Console.WriteLine("Error: Division by zero.");
                else
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                break;
            default:
                Console.WriteLine("Invalid operator. Use +, -, *, x, or /.");
                break;
        }
    }
}
