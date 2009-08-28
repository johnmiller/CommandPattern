namespace CommandPattern
{
    public class TurnRightCommand : ICommand
    {
        private Robot _robot;

        public TurnRightCommand(Robot robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
            _robot.Direction = Compass.GetRightTurnDirection(_robot.Direction);
        }

        public void Undo()
        {
            _robot.Direction = Compass.GetLeftTurnDirection(_robot.Direction);
        }
    }
}