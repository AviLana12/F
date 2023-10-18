using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Multiplication Table");
        Console.WriteLine("====================");

        int size = 10; // Change this value to modify the size of the table

        // Print the header row
        Console.Write("   |");
        for (int i = 1; i <= size; i++)
        {
            Console.Write("{0,4}", i);
        }
        Console.WriteLine();
        Console.WriteLine("----" + new string('-', size * 4));

        // Print the table
        for (int i = 1; i <= size; i++)
        {
            Console.Write("{0,3}|", i);
            for (int j = 1; j <= size; j++) //stashko
            {
                Console.Write("{0,4}", i * j);
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
