public static void Main(string[] args)
    {
        double x, y;
        double radius;
 
        for (int i = 0; i < 360; i += 5)
        {
            radius = i * Math.PI / 180.0;
 
            x = 35 + 8 * Math.Cos(radius);
            y = 10 + 8 * Math.Sin(radius);
 
            Console.SetCursorPosition((int)x, (int)y);
            Console.Write("X");
        }
 
        Console.SetCursorPosition(1, 20);
    }