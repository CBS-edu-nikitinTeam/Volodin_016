
using System;

namespace Exercise2
{
    class Menu
    {
        public static void Show()
        {
            Console.WriteLine("Введите размер массива:");
            if (!int.TryParse(Console.ReadLine(), out int size))
            {
                Console.WriteLine("Вы ввели не число");
                return;
            }
            Console.Write("\n");

            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }

            int summ = 0, min = int.MaxValue, max = int.MinValue;

            Console.Write("Все нечетные значения массива: ");

            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }

                if (max < array[i])
                {
                    max = array[i];
                }

                summ += array[i];

                if (array[i] % 2 != 0)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            Console.Write("\n");
            Console.WriteLine($"Наибольшее значение: {max}");
            Console.WriteLine($"Наименьшее значение: {min}");
            Console.WriteLine($"Сумма всех элементов массива: {summ}");
            Console.WriteLine($"Среднее арифметическое массива: {summ / array.Length}");
        }
    }
}
