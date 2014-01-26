using System;
//2.Write a program that reads the radius r of a circle and prints its perimeter and area.

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Radius of circle: ");
        decimal radius = decimal.Parse(Console.ReadLine());
        decimal areaCircle = (decimal)Math.PI * radius * radius;
        decimal perimeterCircle = (decimal)Math.PI * 2 * radius;
        Console.WriteLine("The perimter of circle is {0:0.00}", perimeterCircle);
        Console.WriteLine("The area of circle is {0:0.00}", areaCircle);
    }
}
