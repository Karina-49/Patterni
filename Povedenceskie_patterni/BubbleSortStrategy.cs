using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Povedenceskie_patterni
{
    public class BubbleSortStrategy : SortingStrategy
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Сортировка пузырьком:");
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}

