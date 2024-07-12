using System;

namespace Summ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomValue = rand.Next(0, 101);
            int minNumber = 0;
            int sum = 0;

            for (int i = minNumber; i <= randomValue; i++)
            {
                bool dividedByThree = i % 3 == 0;
                bool dividedByFive = i % 5 == 0;

                if (dividedByThree || dividedByFive)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Получено случайное число {randomValue}, сумма чисел кратных 3 и 5 этого числа равна {sum}.");
        }
    }
}
