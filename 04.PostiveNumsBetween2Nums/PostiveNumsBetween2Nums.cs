using System;
//4.Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

class PostiveNumsBetween2Nums
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int divBy5 = 0;
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i%5==0)
            {
                divBy5++;
            }
        }
        Console.WriteLine(divBy5);
    }
}
