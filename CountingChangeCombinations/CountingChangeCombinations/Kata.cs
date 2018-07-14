using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingChangeCombinations
{
    public static class Kata
    {
        private static List<List<int>> _list;

        public static int CountCombinations(int money, int[] coins)
        {
            _list = new List<List<int>>();
            coins = coins.OrderBy(x => x).ToArray();
            Dfs(money, coins, 0, new List<int>());

            return _list.Count;
        }

        private static void Dfs(int remain, int[] coins, int deep, List<int> combination)
        {
            if (remain < 0) return;
            if (remain ==0 )
            {
                _list.Add(new List<int>(combination));
                return;
            }

            for (var i = deep; i < coins.Length; i++)
            {
                combination.Add(coins[i]);
                Dfs(remain-coins[i],coins,i,combination);
                combination.RemoveAt(combination.Count - 1);
            }
        }
    }
}
