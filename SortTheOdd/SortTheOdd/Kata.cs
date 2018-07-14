using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTheOdd
{
    public class Kata
    {
        private int[] _array;
        private List<int> _odds;

        public Kata(int[] array)
        {
            _array = array;
        }

        public int[] SortArray()
        {
            if (EmptyHandle())
                return _array;

            FindOddsList();
            SortOdds();

            return _array;

        }

        private void SortOdds()
        {
            for (var i = 0; i < _array.Length; i++)
            {
                if (_array[i] % 2 == 1)
                {
                    _array[i] = _odds[0];
                    _odds.RemoveAt(0);
                }
            }
        }

        private bool EmptyHandle()
        {
            return _array.Length == 0;
        }

        private void FindOddsList()
        {
            _odds = _array.Where(num => num % 2 == 1).OrderBy(x => x).ToList();
        }
    }
}
