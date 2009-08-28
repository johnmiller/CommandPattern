using System.Collections.Generic;

namespace CommandPattern
{
    public class Compass
    {
        private static IList<string> _directions = new List<string>{"N", "E", "S", "W"};

        public static string GetRightTurnDirection(string direction)
        {
            if (direction == _directions[3]) return _directions[0];

            return _directions[_directions.IndexOf(direction) + 1];
        }

        public static string GetLeftTurnDirection(string direction)
        {
            if (direction == _directions[0]) return _directions[3];

            return _directions[_directions.IndexOf(direction) - 1];
        }

        public static string GetOppositeDirection(string direction)
        {
            var directionToTheRight = GetRightTurnDirection(direction);
            return GetRightTurnDirection(directionToTheRight);
        }
    }
}