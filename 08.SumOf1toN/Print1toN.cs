using System;
//8.Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

class Print1toN
{
    static void Main()
    {
        string readInteger = Console.ReadLine();
        int number;
        bool isNumber = int.TryParse(readInteger, out number);
        if (isNumber)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
	    {
            Console.WriteLine("Enter integer number");
	    }
    }
}
