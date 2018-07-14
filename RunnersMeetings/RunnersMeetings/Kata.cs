using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RunnersMeetings
{
    public static class Kata
    {
        private static readonly int _default = -1;
        private static List<int> _nowPosition;
        private static int _nowMaxDiff;

        public static int RunnersMeetings(int[] startPoints, int[] speed)
        {
            var commonSpeed = GetGreatestCommonDivisor(speed);

            if (commonSpeed<2)
                return _default;

            var unitSpeed = speed.Select(x => x / commonSpeed).ToList();
            var preMaxDiff = int.MaxValue;
            _nowPosition = startPoints.ToList();

            while (true)
            {
                SetNewPosition(unitSpeed);
                SetNowMaxDiff();

                if (IsMeeting())
                    return commonSpeed;

                if (_nowMaxDiff > preMaxDiff)
                    return _default;

                preMaxDiff = _nowMaxDiff;
            }    

        }

        private static bool IsMeeting()
        {
            return !_nowPosition.Distinct().Skip(1).Any();
        }

        private static void SetNewPosition(List<int> unitSpeed)
        {
            _nowPosition = _nowPosition.Zip(unitSpeed, (x, y) => (x + y)).ToList();
        }

        private static void SetNowMaxDiff()
        {
            _nowMaxDiff = _nowPosition.Max() - _nowPosition.Min();
        }

        private static int GetGreatestCommonDivisor(int[] numbers)
        {
            return numbers.Aggregate(GetGreatestCommonDivisor);
        }

        private static int GetGreatestCommonDivisor(int a, int b)
        {
            return b == 0 ? a : GetGreatestCommonDivisor(b, a % b);
        }
    }
}
