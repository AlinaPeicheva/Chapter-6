using System;

class Program
{
    static void Main()
    {
        /* Напишете програма, която отпечатва на конзолата числата от 1 до N,
           които не се делят едновременно на 3 и 7.Числото N да се чете от стандартния вход. */
        Console.Write("Въведите N: ");
        int length = Int32.Parse(Console.ReadLine());

        for (int i = 1; i <= length; i++)
        {
            if (i % (3 * 7) != 0)
            Console.WriteLine(i);
        }
    }
}

