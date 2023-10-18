using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("введи число: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("делители от {0}:", number);

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadLine();
    }
}
