using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalsTriangle
{
    public class Kata
    {
        private int[][] _martix;

        public List<int> PascalsTriangle(int n)
        {
            InitailMatrix(n);

            CalculateMatrix();

            var result = MatrixToList();

            return result;

        }

        private List<int> MatrixToList()
        {
            return _martix.SelectMany(x => x).ToList();
        }

        private void CalculateMatrix()
        {
            for (var i = 0; i < _martix.Length; i++)
            {
                for (var j = 1; j < _martix[i].Length - 1; j++)
                {
                    _martix[i][j] = _martix[i - 1][j - 1] + _martix[i - 1][j];
                }
            }
        }

        private void InitailMatrix(int n)
        {
            _martix = new int[n][];

            for (var i = 0; i < n; i++)
            {
                _martix[i] = new int[i + 1];
                for (var j = 0; j <= i; j++)
                {
                    _martix[i][j] = 1;
                }
            }
        }
    }
}
