using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите число B: ");
            int B = int.Parse(Console.ReadLine());//вот тут вот менял умгмуг

            // Проверка: A должно быть меньше или равно B
            if (A > B)
            {
                Console.WriteLine("Ошибка: A должно быть меньше или равно B.");
                return;
            }

            bool foundPositive = false; // Флаг для отслеживания найденных чисел

            // Сначала проверяем, есть ли вообще положительные числа
            for (int i = A; i <= B; i++)
            {
                if (i > 0) // только положительные (ноль не выводим)
                {
                    foundPositive = true;
                    break; // достаточно найти одно положительное число
                }
            }

            // Если не найдено ни одного положительного числа
            if (!foundPositive)
            {
                Console.WriteLine("В диапазоне нет положительных чисел");
                return; // завершаем программу
            }

            // Если есть положительные числа, тогда выводим сообщение и числа
            Console.WriteLine("Вывод положительных чисел из диапазона:");

            for (int i = A; i <= B; i++)
            {
                if (i > 0) // только положительные (ноль не выводим)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}