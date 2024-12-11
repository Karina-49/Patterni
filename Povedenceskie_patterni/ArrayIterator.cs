using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Povedenceskie_patterni
{
    public class ArrayIterator : IIterator
    {
        private int[] items;   // Массив элементов
        private int position;  // Текущая позиция итератора

        // Конструктор принимает массив
        public ArrayIterator(int[] items)
        {
            this.items = items;
            this.position = 0; // Начальная позиция
        }

        // Проверка, есть ли следующий элемент
        public bool HasNext()
        {
            return position < items.Length;
        }

        // Возвращение следующего элемента
        public int Next()
        {
            if (!HasNext())
            {
                throw new InvalidOperationException("Больше нет элементов.");
            }
            return items[position++];
        }
    }

}
