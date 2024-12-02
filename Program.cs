using System;

class Program
{
    static void Main()
    {
        Func<int, long> doubleFactorial = n =>
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return 2 * factorial;
        };

        Console.Write("Введіть число n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"2 * {n}! = {doubleFactorial(n)}");
    }
}
