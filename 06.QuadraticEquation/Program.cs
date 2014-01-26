using System;
//6.Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).


class Program
{
    static void Main()
    {
        Console.WriteLine("ax\xB2+bx+c=0");
        Console.Write("a= ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("b= ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.Write("c= ");
        decimal c = decimal.Parse(Console.ReadLine());
        decimal discriminant = b*b - 4*a*c;
        decimal x1;
        decimal x2;
        if ((discriminant > 0)&&(a!=0))
        {
            x1 = (-b + (decimal)Math.Sqrt((double)discriminant)) / (2 * a);
            x2 = (-b - (decimal)Math.Sqrt((double)discriminant)) / (2 * a);
            Console.WriteLine("There are twoo real roots - x\u2081={0} and  x\u2082={1},", x1, x2);
        }
        else if ((discriminant == 0)&&(a!=0))
        {
            x1 = (-b) / (2 * a);
            Console.WriteLine("There is one real root - x\u2081={0}", x1);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("There are no real roots");
        }
        else if ((a == 0)&&(b!=0)&&(c!=0))
        { 
            x1 = (-c) / b;
            Console.WriteLine("The equation is linear- x\u2081={0}", x1);
        }
        else if ((a==0)&&(b==0)&&(c==0))
            Console.WriteLine("All numbers are roots");
    }
}
