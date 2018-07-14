using System;
using System.Collections.Generic;

namespace CarParkEscape
{
    public class Kata
    {
        private static List<string> _ans = new List<string>();
        private static int[][] _carPark;
        private static int _floor = 0;

        public static string[] Escape(int[][] carPark)
        {
            if (carPark.Length == 0 || 
                carPark[carPark.Length - 1][carPark[0].Length - 1]!=0)
                return _ans.ToArray();

            _carPark = carPark;

            var position = Array.IndexOf(_carPark[_floor], 2);
            while (_floor < _carPark.Length)
            {
                if (_floor == _carPark.Length-1)
                {
                    HandleExit(position);
                    break;
                }
                var stairCase = Array.IndexOf(_carPark[_floor], 1);
                
                HandleFloor(stairCase, position);
                HandleStair(stairCase);

                position = stairCase;
            }

            return _ans.ToArray();
        }

        private static void HandleExit(int stairCase)
        {
            var steps = Math.Abs(_carPark[_carPark.Length - 1].Length - stairCase - 1);
            if (steps != 0) _ans.Add("R" + steps);
        }

        private static void HandleStair(int stair)
        {
            var downFloors = 1;
            while (_floor+ downFloors < _carPark.Length && _carPark[_floor+ downFloors][stair] == 1)
                downFloors += 1;

            _floor += downFloors;
            _ans.Add("D" + downFloors);
        }

        private static void HandleFloor(int stairCase, int position)
        {
            var steps = Math.Abs(stairCase - position);
            if (stairCase - position <= 0)
                _ans.Add("L" + steps);
            else
                _ans.Add("R" + steps);
        }
    }
}