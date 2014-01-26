using System;
//9.Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

class FibonacciSequence
{
    static void Main()
    {
        
        ulong members = 98; 
        Console.Write("0, 1, ");
        ulong firstNumber = 0;
        ulong secondNumber = 1;
        for (uint i = 0; i < (members); i++) //(members -2) because first two members are always 0 and 1
        {
            ulong result = firstNumber + secondNumber;
            Console.Write(result + ", ");
            firstNumber=secondNumber;
            secondNumber=result;
        }
    }
}
