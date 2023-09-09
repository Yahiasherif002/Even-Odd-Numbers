﻿internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        PrintNumbers("Numbers", numbers);
        PrintNumbers("Even Numbers  ", numbers.Where(X => IsEven(X)));
        PrintNumbers("Odd Numbers ", numbers.Where(X => IsOdd(X)));


    }
    static void PrintNumbers (string title , IEnumerable<int> numbers)
    {
        Console.WriteLine();
        Console.Write($"{title}: [");
        foreach (int i in numbers)
        {
            Console.Write($" {i} " );
        }
        Console.Write($"]");
        Console.WriteLine(  );

    }
    static bool IsEven(int number)
    {
        if (number % 2 == 0)
            return true;
        else
            return false;
    }
    static bool IsOdd(int number)
    {
        if (number % 2 != 0)
            return true;
        else
            return false;
        
    }
}