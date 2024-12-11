using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Povedenceskie_patterni
{
    public class Sorter
    {
        private SortingStrategy _strategy;

        public void SetStrategy(SortingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SortArray(int[] array)
        {
            _strategy.Sort(array);
        }
    }
}
