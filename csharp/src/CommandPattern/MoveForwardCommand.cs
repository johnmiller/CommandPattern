using System;
using System.Collections.Generic;

namespace CommandPattern
{
    public class MoveForwardCommand : ICommand
    {
        private Robot _robot;
        private IDictionary<string, Action<Robot>> _moveActions;

        public MoveForwardCommand(Robot robot)
        {
            _robot = robot;
            _moveActions = new Dictionary<string, Action<Robot>>
                               {
                                   {"N", r => r.Position.Y += 1 },
                                   {"E", r => r.Position.X += 1 },
                                   {"S", r => r.Position.Y -= 1 },
                                   {"W", r => r.Position.X -= 1 }
                               };
        }
 
        public void Execute()
        {
            _moveActions[_robot.Direction](_robot);
        }

        public void Undo()
        {
            var oppositeDirection = Compass.GetOppositeDirection(_robot.Direction);
            _moveActions[oppositeDirection](_robot);
        }
    }
}