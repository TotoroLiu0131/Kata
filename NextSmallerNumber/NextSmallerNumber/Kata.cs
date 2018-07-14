using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextSmallerNumber
{
    public class Kata
    {
        private static readonly int _defaultAnswer = -1;
        private static char[] _digitArray;
        private static int _position;
        public static int NextSmallerNumber(int numbers)
         {
             _digitArray = numbers.ToString().ToCharArray();
             for (_position = _digitArray.Length-1; _position >0; _position--)
                if (_digitArray[_position] < _digitArray[_position-1])
                    break;

             if (_position==0) return _defaultAnswer;

             var smallDigit = _digitArray[_position - 1];
             var nextSmallerDigitPosition = _position;

             for (var j = _position + 1 ; j < _digitArray.Length; j++)
                if (_digitArray[j] < smallDigit && _digitArray[j] > _digitArray[nextSmallerDigitPosition])
                    nextSmallerDigitPosition = j;

             swap(_position - 1, nextSmallerDigitPosition);
             DescendArray();
             return int.Parse(_digitArray[0].ToString()) == 0 ? _defaultAnswer : int.Parse(string.Join("", _digitArray));
        }

        private static void DescendArray()
        {
            Array.Sort(_digitArray, _position, _digitArray.Length - _position);
            Array.Reverse(_digitArray, _position, _digitArray.Length - _position);
        }

        private static void swap(int now, int next)
        {
            var temp = _digitArray[now];
            _digitArray[now] = _digitArray[next];
            _digitArray[next] = temp;
        }

       
    }
}
