
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Menu
    {
        public static void Show()
        {
            Console.WriteLine("Введите размер матрицы.");
            Console.WriteLine("Кол-во строк: (от 1 до n)");
            if (!int.TryParse(Console.ReadLine(), out int rows))
            {
                Console.WriteLine("Вы ввели не число");
                return;
            }
            else if (rows <= 0)
            {
                Console.WriteLine("Вы ввели некорректное число");
                return;
            }
            Console.WriteLine("Кол-во столбцов:");
            if (!int.TryParse(Console.ReadLine(), out int columns))
            {
                Console.WriteLine("Вы ввели не число");
                return;
            }
            else if (columns <= 0)
            {
                Console.WriteLine("Вы ввели некорректное число");
                return;
            }

            MyMatrix matrix = new MyMatrix(rows, columns);
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("Измените размер матрицы.");
            Console.WriteLine($"Введите кол-во строк: (от 1 до {rows})");
            if (!int.TryParse(Console.ReadLine(), out int changedRows))
            {
                Console.WriteLine("Вы ввели не число");
                return;
            }
            else if (changedRows <= 0 || changedRows > rows)
            {
                Console.WriteLine($"Вы ввели число не в диапазоне от 1 до {rows}");
                return;
            }
            Console.WriteLine($"Введите кол-во столбцов: (от 1 до {columns})");
            if (!int.TryParse(Console.ReadLine(), out int changedColumns))
            {
                Console.WriteLine("Вы ввели не число");
                return;
            }
            else if (changedColumns <= 0 || changedColumns > columns)
            {
                Console.WriteLine($"Вы ввели число не в диапазоне от 1 до {columns}");
                return;
            }

            for (int i = 0; i < changedRows; i++)
            {
                for (int j = 0; j < changedColumns; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.Write("\n");
            }

        }
    }
}
