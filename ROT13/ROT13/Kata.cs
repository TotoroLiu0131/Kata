using System;

namespace ROT13
{
    public class Kata
    {
        private static string _result;

        public static string Rot13(string str)
        {
            _result = "";
            foreach (var letter in str)
                if (IsAatoMm(letter))
                    _result += Convert.ToChar(letter + 13);
                else if (IsNntoZz(letter))
                    _result += Convert.ToChar(letter - 13);
                else
                    _result += letter;
            return _result;
        }

        private static bool IsAatoMm(int number)
        {
            return number >= 65 && number <= 77 || number >= 97 && number <= 109;
        }

        private static bool IsNntoZz(int number)
        {
            return number >= 78 && number <= 90 || number >= 110 && number <= 122;
        }
    }
}