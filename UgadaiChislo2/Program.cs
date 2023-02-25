using System;

namespace UgadaiChislo2
{
    class Program
    {
        private static int b;

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 11);
            int a = 1;
            Console.Write("Я загадал число от 1 до 10, попробуй угадать за 5 попыток ");
            Console.Write("\nКакое число я загадал?: ");
            b = int.Parse(Console.ReadLine());
            while (a != 5)
            {
                if (b == x)
                {
                    Console.Write("\n Поздравляю, ты угадал!");
                    Console.Write("\n Введи что-то чтобы выйти: ");
                    string f = Console.ReadLine();
                    break;
                }
                else
                {
                    if (b > x)
                    {
                        Console.Write("\n Нет, мое число меньше.");
                        a++;
                        Console.Write("\nКакое число я загадал?: ");
                        b = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.Write("\n Нет, мое число больше.");
                        a++;
                        Console.Write("\nКакое число я загадал?: ");
                        b = int.Parse(Console.ReadLine());

                    }
                }
                if (a == 5)
                {
                    Console.Write("\n Попытки закончились. Ты проиграл.");
                    Console.Write("\n Введи что-то чтобы выйти: ");
                    string f = Console.ReadLine();
                }
            }
        }

    }
}





