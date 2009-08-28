using NUnit.Framework;

namespace CommandPattern.Specs
{
    [TestFixture]
    public class When_creating_a_new_robot
    {
        private Robot _robot;

        [SetUp]
        public void EstablishContext()
        {
            _robot = new Robot(new Location(5, 5), "N");
        }

        [Test]
        public void Should_be_on_the_starting_tile()
        {
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
        }

        [Test]
        public void Should_be_facing_in_the_starting_direction()
        {
            Assert.That(_robot.Direction, Is.EqualTo("N"));
        }
    }

    [TestFixture]
    public class When_facing_north_and_given_the_command_to_move_forward
    {
        private Robot _robot;

        [SetUp]
        public void EstablishContext()
        {
            _robot = new Robot(new Location(5, 5), "N");
            _robot.ExecuteInstruction(new MoveForwardCommand(_robot));
        }

        [Test]
        public void Should_move_north_one_space()
        {
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(6));
        }

        [Test]
        public void Should_not_change_directions()
        {
            Assert.That(_robot.Direction, Is.EqualTo("N"));
        }

        [Test]
        public void Should_be_able_to_undo_the_command()
        {
            _robot.Reset();
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
            Assert.That(_robot.Direction, Is.EqualTo("N"));
        }
    }

    [TestFixture]
    public class When_facing_east_and_given_the_command_to_move_forward
    {
        private Robot _robot;

        [SetUp]
        public void EstablishContext()
        {
            _robot = new Robot(new Location(5, 5), "E");
            _robot.ExecuteInstruction(new MoveForwardCommand(_robot));
        }

        [Test]
        public void Should_move_east_one_space()
        {
            Assert.That(_robot.Position.X, Is.EqualTo(6));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
        }

        [Test]
        public void Should_not_change_directions()
        {
            Assert.That(_robot.Direction, Is.EqualTo("E"));
        }

        [Test]
        public void Should_be_able_to_undo_the_command()
        {
            _robot.Reset();
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
            Assert.That(_robot.Direction, Is.EqualTo("E"));
        }
    }

    [TestFixture]
    public class When_facing_south_and_given_the_command_to_move_forward
    {
        private Robot _robot;

        [SetUp]
        public void EstablishContext()
        {
            _robot = new Robot(new Location(5, 5), "S");
            _robot.ExecuteInstruction(new MoveForwardCommand(_robot));
        }

        [Test]
        public void Should_move_south_one_space()
        {
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(4));
        }

        [Test]
        public void Should_not_change_directions()
        {
            Assert.That(_robot.Direction, Is.EqualTo("S"));
        }

        [Test]
        public void Should_be_able_to_undo_the_command()
        {
            _robot.Reset();
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
            Assert.That(_robot.Direction, Is.EqualTo("S"));
        }
    }

    [TestFixture]
    public class When_facing_west_and_given_the_command_to_move_forward
    {
        private Robot _robot;

        [SetUp]
        public void EstablishContext()
        {
            _robot = new Robot(new Location(5, 5), "W");
            _robot.ExecuteInstruction(new MoveForwardCommand(_robot));
        }

        [Test]
        public void Should_move_north_one_space()
        {
            Assert.That(_robot.Position.X, Is.EqualTo(4));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
        }

        [Test]
        public void Should_not_change_directions()
        {
            Assert.That(_robot.Direction, Is.EqualTo("W"));
        }

        [Test]
        public void Should_be_able_to_undo_the_command()
        {
            _robot.Reset();
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
            Assert.That(_robot.Direction, Is.EqualTo("W"));
        }
    }

    [TestFixture]
    public class When_facing_north_and_given_the_command_to_turn_right
    {
        private Robot _robot;

        [SetUp]
        public void EstablishContext()
        {
            _robot = new Robot(new Location(5, 5), "N");
            _robot.ExecuteInstruction(new TurnRightCommand(_robot));
        }

        [Test]
        public void Should_remain_in_the_same_space()
        {
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
        }

        [Test]
        public void Should_be_facing_east()
        {
            Assert.That(_robot.Direction, Is.EqualTo("E"));
        }

        [Test]
        public void Should_be_able_to_undo_the_command()
        {
            _robot.Reset();
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
            Assert.That(_robot.Direction, Is.EqualTo("N"));
        }
    }

    [TestFixture]
    public class When_facing_east_and_given_the_command_to_turn_right
    {
        private Robot _robot;

        [SetUp]
        public void EstablishContext()
        {
            _robot = new Robot(new Location(5, 5), "E");
            _robot.ExecuteInstruction(new TurnRightCommand(_robot));
        }

        [Test]
        public void Should_remain_in_the_same_space()
        {
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
        }

        [Test]
        public void Should_be_facing_south()
        {
            Assert.That(_robot.Direction, Is.EqualTo("S"));
        }

        [Test]
        public void Should_be_able_to_undo_the_command()
        {
            _robot.Reset();
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
            Assert.That(_robot.Direction, Is.EqualTo("E"));
        }
    }

    [TestFixture]
    public class When_facing_south_and_given_the_command_to_turn_right
    {
        private Robot _robot;

        [SetUp]
        public void EstablishContext()
        {
            _robot = new Robot(new Location(5, 5), "S");
            _robot.ExecuteInstruction(new TurnRightCommand(_robot));
        }

        [Test]
        public void Should_remain_in_the_same_space()
        {
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
        }

        [Test]
        public void Should_be_facing_west()
        {
            Assert.That(_robot.Direction, Is.EqualTo("W"));
        }

        [Test]
        public void Should_be_able_to_undo_the_command()
        {
            _robot.Reset();
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
            Assert.That(_robot.Direction, Is.EqualTo("S"));
        }
    }

    [TestFixture]
    public class When_facing_west_and_given_the_command_to_turn_right
    {
        private Robot _robot;

        [SetUp]
        public void EstablishContext()
        {
            _robot = new Robot(new Location(5, 5), "W");
            _robot.ExecuteInstruction(new TurnRightCommand(_robot));
        }

        [Test]
        public void Should_remain_in_the_same_space()
        {
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
        }

        [Test]
        public void Should_be_facing_north()
        {
            Assert.That(_robot.Direction, Is.EqualTo("N"));
        }

        [Test]
        public void Should_be_able_to_undo_the_command()
        {
            _robot.Reset();
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
            Assert.That(_robot.Direction, Is.EqualTo("W"));
        }
    }

    [TestFixture]
    public class When_facing_north_and_given_the_command_to_turn_left
    {
        private Robot _robot;

        [SetUp]
        public void EstablishContext()
        {
            _robot = new Robot(new Location(5, 5), "N");
            _robot.ExecuteInstruction(new TurnLeftCommand(_robot));
        }

        [Test]
        public void Should_remain_in_the_same_space()
        {
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
        }

        [Test]
        public void Should_be_facing_west()
        {
            Assert.That(_robot.Direction, Is.EqualTo("W"));
        }

        [Test]
        public void Should_be_able_to_undo_the_command()
        {
            _robot.Reset();
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
            Assert.That(_robot.Direction, Is.EqualTo("N"));
        }
    }

    [TestFixture]
    public class When_facing_east_and_given_the_command_to_turn_left
    {
        private Robot _robot;

        [SetUp]
        public void EstablishContext()
        {
            _robot = new Robot(new Location(5, 5), "E");
            _robot.ExecuteInstruction(new TurnLeftCommand(_robot));
        }

        [Test]
        public void Should_remain_in_the_same_space()
        {
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
        }

        [Test]
        public void Should_be_facing_north()
        {
            Assert.That(_robot.Direction, Is.EqualTo("N"));
        }

        [Test]
        public void Should_be_able_to_undo_the_command()
        {
            _robot.Reset();
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
            Assert.That(_robot.Direction, Is.EqualTo("E"));
        }
    }

    [TestFixture]
    public class When_facing_south_and_given_the_command_to_turn_left
    {
        private Robot _robot;

        [SetUp]
        public void EstablishContext()
        {
            _robot = new Robot(new Location(5, 5), "S");
            _robot.ExecuteInstruction(new TurnLeftCommand(_robot));
        }

        [Test]
        public void Should_remain_in_the_same_space()
        {
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
        }

        [Test]
        public void Should_be_facing_east()
        {
            Assert.That(_robot.Direction, Is.EqualTo("E"));
        }

        [Test]
        public void Should_be_able_to_undo_the_command()
        {
            _robot.Reset();
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
            Assert.That(_robot.Direction, Is.EqualTo("S"));
        }
    }

    [TestFixture]
    public class When_facing_west_and_given_the_command_to_turn_left
    {
        private Robot _robot;

        [SetUp]
        public void EstablishContext()
        {
            _robot = new Robot(new Location(5, 5), "W");
            _robot.ExecuteInstruction(new TurnLeftCommand(_robot));
        }

        [Test]
        public void Should_remain_in_the_same_space()
        {
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
        }

        [Test]
        public void Should_be_facing_south()
        {
            Assert.That(_robot.Direction, Is.EqualTo("S"));
        }

        [Test]
        public void Should_be_able_to_undo_the_command()
        {
            _robot.Reset();
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
            Assert.That(_robot.Direction, Is.EqualTo("W"));
        }
    }

    [TestFixture]
    public class When_a_robot_is_given_multiple_commands
    {
        private Robot _robot;

        [SetUp]
        public void EstablishContext()
        {
            _robot = new Robot(new Location(5, 5), "W");
            _robot.ExecuteInstruction(new TurnLeftCommand(_robot));
            _robot.ExecuteInstruction(new TurnLeftCommand(_robot));
            _robot.ExecuteInstruction(new MoveForwardCommand(_robot));
            _robot.ExecuteInstruction(new TurnRightCommand(_robot));
            _robot.ExecuteInstruction(new MoveForwardCommand(_robot));
            _robot.ExecuteInstruction(new TurnRightCommand(_robot));
            _robot.ExecuteInstruction(new MoveForwardCommand(_robot));
            _robot.ExecuteInstruction(new MoveForwardCommand(_robot));
            _robot.ExecuteInstruction(new TurnRightCommand(_robot));
        }

        [Test]
        public void Should_end_up_at_the_expected_location()
        {
            Assert.That(_robot.Position.X, Is.EqualTo(4));
            Assert.That(_robot.Position.Y, Is.EqualTo(4)); ;
        }

        [Test]
        public void Should_be_facing_the_expected_direction()
        {
            Assert.That(_robot.Direction, Is.EqualTo("N"));
        }

        [Test]
        public void Should_be_able_to_undo_the_command()
        {
            _robot.Reset();
            Assert.That(_robot.Position.X, Is.EqualTo(5));
            Assert.That(_robot.Position.Y, Is.EqualTo(5));
            Assert.That(_robot.Direction, Is.EqualTo("W"));
        }
    }
}