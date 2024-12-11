using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Povedenceskie_patterni
{
    // Класс коллекции для хранения массива int
    public class ArrayCollection
    {
        private int[] items; // Массив элементов

        // Конструктор принимает массив
        public ArrayCollection(int[] items)
        {
            this.items = items;
        }

        // Метод для получения итератора
        public IIterator GetIterator()
        {
            return new ArrayIterator(items);
        }
    }

}
