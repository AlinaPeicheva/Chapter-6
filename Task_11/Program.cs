using System;


class Program
{
    static void Main()
    {
        // Напишете програма, която пресмята с колко нули завършва факториелът на дадено число. 

        Console.Write("Въведите N: ");
        decimal n = Int32.Parse(Console.ReadLine());
        int zeroes = 0;

        for (int i = (int)(n - 1); i > 0; i--)
            n *= i;

        Console.Write("N! е {0} и се завършва с", n);

        do
        {
            n /= 10;
            zeroes++;
        } while (n % 10 == 0);

        Console.WriteLine(" {0} нули.", zeroes);

    }
}

