require File.expand_path(File.dirname(__FILE__) + '/spec_helper')

describe "When creating a new robot" do
  before(:each) do
    @robot = Robot.new Location.new(5,5), :N
  end

  it "should be on the starting tile" do
    @robot.position.x.should == 5
    @robot.position.y.should == 5
  end

  it "should be facing the starting direction" do
    @robot.direction.should == :N
  end
end

describe "When facing north" do
  before(:each) do
    @robot = Robot.new Location.new(5,5), :N
  end

  describe "and asked to move forward" do
    before(:each) do
      @robot.execute_instruction MoveForwardCommand.new(@robot)
    end

    it "should move north one space" do
      @robot.position.x.should == 5
      @robot.position.y.should == 6
    end

    it "should not change directions" do
      @robot.direction.should == :N
    end

    it "should be able to undo the command" do
      @robot.reset
      @robot.position.x.should == 5
      @robot.position.y.should == 5
      @robot.direction.should == :N
    end
  end

  describe "and asked to turn right" do
    before(:each) do
      @robot.execute_instruction TurnRightCommand.new(@robot)
    end

    it "should remain in the same space" do
      @robot.position.x.should == 5
      @robot.position.y.should == 5
    end

    it "should be facing east" do
      @robot.direction.should == :E
    end

    it "should be able to undo the command" do
      @robot.reset
      @robot.position.x.should == 5
      @robot.position.y.should == 5
      @robot.direction.should == :N
    end
  end

  describe "and asked to turn left" do
    before(:each) do
      @robot.execute_instruction TurnLeftCommand.new(@robot)
    end

    it "should remain in the same space" do
      @robot.position.x.should == 5
      @robot.position.y.should == 5
    end

    it "should be facing west" do
      @robot.direction.should == :W
    end

    it "should be able to undo the command" do
      @robot.reset
      @robot.position.x.should == 5
      @robot.position.y.should == 5
      @robot.direction.should == :N
    end
  end
end

describe "When facing east" do
  before(:each) do
    @robot = Robot.new Location.new(5,5), :E
  end

  describe "and asked to move forward" do
    before(:each) do
      @robot.execute_instruction MoveForwardCommand.new(@robot)
    end

    it "should move east one space" do
      @robot.position.x.should == 6
      @robot.position.y.should == 5
    end

    it "should not change directions" do
      @robot.direction.should == :E
    end

    it "should be able to undo the command" do
      @robot.reset
      @robot.position.x.should == 5
      @robot.position.y.should == 5
      @robot.direction.should == :E
    end
  end

  describe "and asked to turn right" do
    before(:each) do
      @robot.execute_instruction TurnRightCommand.new(@robot)
    end

    it "should remain in the same space" do
      @robot.position.x.should == 5
      @robot.position.y.should == 5
    end

    it "should be facing south" do
      @robot.direction.should == :S
    end

    it "should be able to undo the command" do
      @robot.reset
      @robot.position.x.should == 5
      @robot.position.y.should == 5
      @robot.direction.should == :E
    end
  end

  describe "and asked to turn left" do
    before(:each) do
      @robot.execute_instruction TurnLeftCommand.new(@robot)
    end

    it "should remain in the same space" do
      @robot.position.x.should == 5
      @robot.position.y.should == 5
    end

    it "should be facing north" do
      @robot.direction.should == :N
    end

    it "should be able to undo the command" do
      @robot.reset
      @robot.position.x.should == 5
      @robot.position.y.should == 5
      @robot.direction.should == :E
    end
  end
end

describe "When facing south" do
  before(:each) do
    @robot = Robot.new Location.new(5,5), :S
  end

  describe "and asked to move forward" do
    before(:each) do
      @robot.execute_instruction MoveForwardCommand.new(@robot)
    end

    it "should move south one space" do
      @robot.position.x.should == 5
      @robot.position.y.should == 4
    end

    it "should not change directions" do
      @robot.direction.should == :S
    end

    it "should be able to undo the command" do
      @robot.reset
      @robot.position.x.should == 5
      @robot.position.y.should == 5
      @robot.direction.should == :S
    end
  end

  describe "and asked to turn right" do
    before(:each) do
      @robot.execute_instruction TurnRightCommand.new(@robot)
    end

    it "should remain in the same space" do
      @robot.position.x.should == 5
      @robot.position.y.should == 5
    end

    it "should be facing west" do
      @robot.direction.should == :W
    end

    it "should be able to undo the command" do
      @robot.reset
      @robot.position.x.should == 5
      @robot.position.y.should == 5
      @robot.direction.should == :S
    end
  end

  describe "and asked to turn left" do
    before(:each) do
      @robot.execute_instruction TurnLeftCommand.new(@robot)
    end

    it "should remain in the same space" do
      @robot.position.x.should == 5
      @robot.position.y.should == 5
    end

    it "should be facing east" do
      @robot.direction.should == :E
    end

    it "should be able to undo the command" do
      @robot.reset
      @robot.position.x.should == 5
      @robot.position.y.should == 5
      @robot.direction.should == :S
    end
  end
end

describe "When facing west" do
  before(:each) do
    @robot = Robot.new Location.new(5,5), :W
  end

  describe "and asked to move forward" do
    before(:each) do
      @robot.execute_instruction MoveForwardCommand.new(@robot)
    end

    it "should move west one space" do
      @robot.position.x.should == 4
      @robot.position.y.should == 5
    end

    it "should not change directions" do
      @robot.direction.should == :W
    end

    it "should be able to undo the command" do
      @robot.reset
      @robot.position.x.should == 5
      @robot.position.y.should == 5
      @robot.direction.should == :W
    end
  end

  describe "and asked to turn right" do
    before(:each) do
      @robot.execute_instruction TurnRightCommand.new(@robot)
    end

    it "should remain in the same space" do
      @robot.position.x.should == 5
      @robot.position.y.should == 5
    end

    it "should be facing north" do
      @robot.direction.should == :N
    end

    it "should be able to undo the command" do
      @robot.reset
      @robot.position.x.should == 5
      @robot.position.y.should == 5
      @robot.direction.should == :W
    end
  end

  describe "and asked to turn left" do
    before(:each) do
      @robot.execute_instruction TurnLeftCommand.new(@robot)
    end

    it "should remain in the same space" do
      @robot.position.x.should == 5
      @robot.position.y.should == 5
    end

    it "should be facing south" do
      @robot.direction.should == :S
    end

    it "should be able to undo the command" do
      @robot.reset
      @robot.position.x.should == 5
      @robot.position.y.should == 5
      @robot.direction.should == :W
    end
  end
end

describe "When asked to perform multiple commands" do
  before(:each) do
    @robot = Robot.new Location.new(5,5), :W
    @robot.execute_instruction TurnLeftCommand.new(@robot)
    @robot.execute_instruction TurnLeftCommand.new(@robot)
    @robot.execute_instruction MoveForwardCommand.new(@robot)
    @robot.execute_instruction TurnRightCommand.new(@robot)
    @robot.execute_instruction MoveForwardCommand.new(@robot)
    @robot.execute_instruction TurnRightCommand.new(@robot)
    @robot.execute_instruction MoveForwardCommand.new(@robot)
    @robot.execute_instruction MoveForwardCommand.new(@robot)
    @robot.execute_instruction TurnRightCommand.new(@robot)
  end

  it "should end up at the expected location" do
    @robot.position.x.should == 4
    @robot.position.y.should == 4
  end

  it "should be facing the expected direction" do
    @robot.direction.should == :N
  end

  it "should be able to undo all of the commands" do
    @robot.reset
    @robot.position.x.should == 5
    @robot.position.y.should == 5
    @robot.direction.should == :W
  end
end
