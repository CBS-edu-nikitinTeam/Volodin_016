using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    static class StoreGenerator
    {
        public static Store Generate()
        {
            Store store = new Store(10);

            store[0] = new Article("Персик", "Супермаркет", 20);
            store[1] = new Article("Яблоко", "Супермаркет", 10);
            store[2] = new Article("Апельсин", "Супермаркет", 30);
            store[3] = new Article("Груша", "Супермаркет", 20);
            store[4] = new Article("Арбуз", "Супермаркет", 30);
            store[5] = new Article("Киви", "Супермаркет", 30);
            store[6] = new Article("Сникерс", "Магазин", 15);
            store[7] = new Article("Марс", "Магазин", 16);
            store[8] = new Article("Натс", "Магазин", 17);
            store[9] = new Article("Несквик", "Магазин", 18);

            return store;
        }
    }
}
