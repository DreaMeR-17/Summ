using System;

namespace Summ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sum = 0;
            int maxRandomValue = 101;
            int minRandomValue = 0;
            int divider1 = 3;
            int divider2 = 5; 
            int randomValue = random.Next(minRandomValue, maxRandomValue);

            for (int i = divider1; i <= randomValue; i++)
            {
                if (i % divider1 == 0 || i % divider2 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Получено случайное число {randomValue}, сумма чисел кратных {divider1} и {divider2} этого числа равна {sum}.");
        }
    }
}
