using System;


class Program
{
    static void Main()
    {
        // Напишете програма, която отпечатва на конзолата числата от 1 до N. Числото N трябва да се чете от стандартния вход.
        Console.Write("Въведите положително число: ");
        int length = int.Parse(Console.ReadLine());

        for (int i = 1; i <= length; i++)
            Console.WriteLine(i);
    }
}

