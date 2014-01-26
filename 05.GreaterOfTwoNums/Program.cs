using System;
//5.Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

class GreaterOfTwoNums
{
    static void Main()
    {
        Console.Write("First number: ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        decimal result = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("The greater number is {0}", result);

    }
}
