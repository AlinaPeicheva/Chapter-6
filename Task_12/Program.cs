using System;


class Program
{
    static void Main()
    {
        // Напишете програма, която преобразува дадено число от десетична в двоична бройна система.

        Console.Write("Въведите число: ");
        int n = Int32.Parse(Console.ReadLine());
        string binary = Convert.ToString(n, 2);
        Console.WriteLine("Резултата е {0}", binary);
    }
}


