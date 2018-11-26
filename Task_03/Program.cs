using System;

class Program
{
    static void Main()
    {
        //Напишете програма, която чете от конзолата поредица от цели числа и  отпечатва най-малкото и най-голямото от тях.

        int lowest = 0, highest = 0, input;

        Console.Write("Въведете число на дължината: ");
        int lenght = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < lenght; i++)
        {
            Console.Write("Въведите число: ");
            input = Int32.Parse(Console.ReadLine());
            if (i == 0) lowest = highest = input;
            else
            {
                if (lowest > input) lowest = input;
                if (highest < input) highest = input;
            }
        }
        Console.WriteLine("Най-малкото - {0}, Най-голямото - {1}", lowest, highest);
    }
}

