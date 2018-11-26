using System;


class Program
{
    static void Main(string[] args)
    {
        // Напишете програма, която пресмята N!/K! за дадени N и K (1<K<N).

        Console.Write("Въведите N (1<K<N): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Въведите K (1<K<N): ");
        int k = int.Parse(Console.ReadLine());

        for (int i = n - 1; i > 0; i--)
        {
            n *= i;
        }

        for (int i = k - 1; i > 0; i--)
        {
            k *= i;
        }

        n /= k;
        Console.WriteLine("N!/K! = {0}", n);
    }
}
