using System;
//10.Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...


class Program
{
    static void Main()
    {
        decimal numbers = 0m;
        decimal denominator = 1m;
        for (decimal i = 1; i <= 1000; i++) //Count to 1/1000==0.001 accuracy
        {
            if ((i %2!=0)&&(i!=1))
            {
                denominator = (-1) * i;
            }
            else
            {
                denominator = i;
            }
            numbers += 1 / denominator;
        }
        Console.WriteLine("The sum of the numbers is: {0:0.000}", numbers);
    }
}
