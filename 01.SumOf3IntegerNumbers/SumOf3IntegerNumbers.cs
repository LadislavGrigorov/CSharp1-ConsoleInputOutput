using System;
//1. Write a program that reads 3 integer numbers from the console and prints their sum.

class SumOf3IntegerNumbers
{
    static void Main()
    {
        Console.Write("a=");
        int numberOne = int.Parse(Console.ReadLine());
        Console.Write("b=");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.Write("c=");
        int numberTree = int.Parse(Console.ReadLine());
        int result = numberOne + numberTwo + numberTree;
        Console.WriteLine("{0}+{1}+{2}={3}", numberOne, numberTwo, numberTree, result);

    }
}
