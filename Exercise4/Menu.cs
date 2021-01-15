using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Menu
    {
        public static void Show()
        {
            Store store = StoreGenerator.Generate();

            Console.WriteLine("Вывод информации о продуктах");
            Console.WriteLine("1. Поиск продукта по номеру");
            Console.WriteLine("2. Поиск продукта по имени");

           if (!int.TryParse(Console.ReadLine(), out int actionNumber))
            {
                Console.WriteLine("Вы ввели не число.");
                return;
            }
            Console.Write("\n");

           switch (actionNumber)
            {
                case 1:
                    ShowProductByIndex(store);
                    break;
                case 2:
                    ShowProductByName(store);
                    break;
                default:
                    Console.WriteLine("Вы ввели некорректный номер действия.");
                    break;
            }
        }

        private static void ShowProductByIndex(Store store)
        {
            Console.WriteLine("Введите номер продукт (0-9): ");

            if (!int.TryParse(Console.ReadLine(), out int index))
            {
                Console.WriteLine("Вы ввели не число.");
                return;
            }

            if (index < 0 || index > 9)
            {
                Console.WriteLine("Вы ввели число не в промежутке 0-9");
                return;
            }

            store[index].Details();
        }

        private static void ShowProductByName(Store store)
        {
            Console.WriteLine("Введите название продукта: ");
            string productName = Console.ReadLine();
            Console.Write("\n");

            Article article = store.GetArticleByProductName(productName);

            if (article == null)
            {
                Console.WriteLine($"Не удалось найти продукт с именем {productName}");
                return;
            }
            article.Details();
        }
    }
}
