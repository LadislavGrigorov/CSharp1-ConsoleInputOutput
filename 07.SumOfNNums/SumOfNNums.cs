using System;
//7.Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
class SumOfNNums
{
    static void Main()
    {
        Console.Write("n= ");
        string stringNumber = Console.ReadLine();
        int number;
        int sum = 0;
        if ((int.TryParse(stringNumber, out number))&&(number>0))
        {
            for (int i = 1; i <=number; i++)
            {
                string otherNumber = Console.ReadLine();
                int numberForSum;
                if (int.TryParse(otherNumber, out numberForSum))
                {
                    sum += numberForSum;
                }
                else
                {
                    Console.WriteLine("Enter integer number!");
                    i--;
                }

            }
            Console.WriteLine(sum);

        }
        else
        {
            Console.WriteLine("Enter integer number!");
        }
    }
}
