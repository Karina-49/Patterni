using System;
using System.Collections.Generic;
using System.Globalization;

using System;

using System;

namespace Povedenceskie_patterni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Паттерн 'Стратегия' ===");

            int[] array = { 5, 3, 8, 4, 2 };

            var sorter = new Sorter();

            // Использование стратегии пузырьковой сортировки
            sorter.SetStrategy(new BubbleSortStrategy());
            sorter.SortArray(array);

            // Использование стратегии быстрой сортировки
            sorter.SetStrategy(new QuickSortStrategy());
            sorter.SortArray(array);

            Console.WriteLine("Все стратегии отработали успешно!");
        }
    }
}
