using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Povedenceskie_patterni
{
    public class QuickSortStrategy : SortingStrategy
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Быстрая сортировка:");
            QuickSort(array, 0, array.Length - 1);
            Console.WriteLine(string.Join(", ", array));
        }

        private void QuickSort(int[] array, int left, int right)
        {
            if (left >= right) return;

            int pivot = array[(left + right) / 2];
            int index = Partition(array, left, right, pivot);
            QuickSort(array, left, index - 1);
            QuickSort(array, index, right);
        }

        private int Partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (array[left] < pivot) left++;
                while (array[right] > pivot) right--;
                if (left <= right)
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                    left++;
                    right--;
                }
            }
            return left;
        }
    }
}
