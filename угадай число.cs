class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\"Угадай число\"");
        Console.WriteLine("Угадай число (от 0 до 50)");
        Random random = new Random();
        int ZagChislo = random.Next(0, 50);
        Console.WriteLine(ZagChislo);
        int n = 0;
        while (true)
        {
            Console.Write("Ваше число: ");
            string stroka = Console.ReadLine();

            while (!int.TryParse(stroka, out n))
            {
                Console.WriteLine("\nЭто не число");
                Console.WriteLine("Повторите");
                stroka = Console.ReadLine();
            }
            if (n != ZagChislo)
            {
                Console.WriteLine("Неа, попробуй ещё раз"); //stashko
                if (n > ZagChislo)
                {
                    Console.WriteLine("Нужно число поменьше\n");
                }
                else
                {
                    Console.WriteLine("Нужно число побольше\n");
                }
            }
            else
            {
                Console.WriteLine("\nДа,ты угадал число");
                break;
            }
        }
        Console.ReadKey();
    }
}
}