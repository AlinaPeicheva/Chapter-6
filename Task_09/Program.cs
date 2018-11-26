using System;

class Program
{
    static void Main()
    {
        // Напишете програма, която за дадени цели числа n и x, пресмятa сумата по формула...

        int sum = 1, temp = 1;
        Console.Write("Въведите n: ");
        int n = Int32.Parse(Console.ReadLine());
        Console.Write("Въведите x: ");
        int x = Int32.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            temp *= i / x;
            sum += temp;
        }

        Console.WriteLine("Резултата е {0}", sum);
    }
}

