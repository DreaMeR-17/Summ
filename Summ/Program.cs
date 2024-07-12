using System;

namespace Summ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomValue = random.Next(0, 101);
            int sum = 0;
            int divider1 = 3;
            int divider2 = 5;

            for (int i = divider1; i <= randomValue; i++)
            {
                if (i % divider1 == 0 || i % divider2 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Получено случайное число {randomValue}, сумма чисел кратных 3 и 5 этого числа равна {sum}.");
        }
    }
}
