using System;


class Program
{
    static void Main()
    {
        // Напишете програма, която преобразува дадено число от двоична в десетична бройна система.
        Console.Write("Въведите двоично число: ");
        int num = Int32.Parse(Console.ReadLine());
        int binVal, decVal = 0, baseVal = 1, rem;
        binVal = num;

        while (num > 0)
        {
            rem = num % 10;
            decVal = decVal + rem * baseVal;
            num = num / 10;

            baseVal = baseVal * 2;
        }
        Console.WriteLine("В десетична бройна система: " + decVal);

    }
}

