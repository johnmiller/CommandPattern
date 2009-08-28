namespace CommandPattern
{
    public class TurnLeftCommand : ICommand
    {
        private Robot _robot;
        
        public TurnLeftCommand(Robot robot) 
        {
            _robot = robot; 
        }

        public void Execute()
        {
            _robot.Direction = Compass.GetLeftTurnDirection(_robot.Direction);
        }

        public void Undo()
        {
            _robot.Direction = Compass.GetRightTurnDirection(_robot.Direction);
        }
    }
}