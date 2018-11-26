using System;


class Program
{
    static void Main()
    {
        // Напишете програма, която преобразува дадено число от шестнайсетична в десетична бройна система.

        Console.Write("Въведите шестнайсетично число: ");

        string hexValues = Console.ReadLine();
        string[] hexValuesSplit = hexValues.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
  
        foreach (String hex in hexValuesSplit)
        {
            // Конвертираме числото в десетична бройна система.
            int value = Convert.ToInt32(hex, 16);
            Console.WriteLine(string.Format("{0} = {1}", hex, Convert.ToDecimal(value)));
        }

    }
}

