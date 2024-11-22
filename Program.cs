using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер члена ряда Фибоначчи (n): ");
        int n = int.Parse(Console.ReadLine());

        int fibonacciNumber = Fibonacci(n);
        Console.WriteLine($"n-ый член ряда Фибоначчи (F({n})) = {fibonacciNumber}");
    }

    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}