using System;


class Program
{
    static void Main()
    {
        // Напишете програма, която за дадени две числа, намира най-големия им общ делител(НОД)

        Console.Write("Въведите първото число: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("въведите второто число: ");
        int b = Int32.Parse(Console.ReadLine());

        while (a != 0 && b != 0)
        {
            if (a > b) a %= b;
            else b %= a;
        }

        if (a == 0) Console.WriteLine(b);
        else Console.WriteLine(a);
    }
}

