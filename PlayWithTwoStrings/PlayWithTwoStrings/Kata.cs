using System.Collections.Generic;

namespace PlayWithTwoStrings
{
    public static class Kata
    {
        private static string _combineResult;
        private static Dictionary<char, int> _dictionaryA;
        private static Dictionary<char, int> _dictionaryB;

        public static string CombinTwoWorkOnStrings(string a, string b)
        {
            _combineResult = "";
            _dictionaryA = new Dictionary<char, int>();
            _dictionaryB = new Dictionary<char, int>();

            CountStringLetter(a, _dictionaryA);
            CountStringLetter(b, _dictionaryB);
            CombineTwoString(a, _dictionaryB);
            CombineTwoString(b, _dictionaryA);

            return _combineResult;
        }

        private static void CombineTwoString(string str, Dictionary<char, int> dic)
        {
            foreach (var letter in str)
            {
                var key = char.ToLower(letter);
                if (dic.ContainsKey(key))
                {
                    if (char.IsLower(letter))
                    {
                        _combineResult += dic[key] % 2 == 0 ? letter : char.ToUpper(letter);
                    }
                    else if (char.IsUpper(letter))
                    {
                        _combineResult += dic[key] % 2 == 0 ? letter : char.ToLower(letter);
                    }
                }
                else
                {
                    _combineResult += letter;
                }
            }
        }

        private static void CountStringLetter(string str, Dictionary<char, int> dic)
        {
            foreach (var letter in str.ToLower())
            {
                var key = char.ToLower(letter);
                if (!dic.ContainsKey(key))
                {
                    dic.Add(key, 0);
                }
                dic[key] += 1;
            }
        }
    }
}