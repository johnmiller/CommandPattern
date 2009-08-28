using System.Collections.Generic;
using System.Linq;

namespace CommandPattern
{
    public class Robot
    {
        public Location Position { get; set; }
        public string Direction { get; set; }
        private IList<ICommand> _commandsExecuted = new List<ICommand>();

        public Robot(Location position, string direction)
        {
            Position = position;
            Direction = direction;
        }

        public void ExecuteInstruction(ICommand command)
        {
            command.Execute();
            _commandsExecuted.Add(command);
        }

        public void Reset()
        {
            foreach (var command in _commandsExecuted.Reverse())
                command.Undo();
        }
    }
}