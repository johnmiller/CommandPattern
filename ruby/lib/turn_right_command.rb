class TurnRightCommand
	def initialize(robot)
		@robot = robot
    end

    def execute
		@robot.direction = Compass.get_right_turn_direction @robot.direction
    end

    def undo
		@robot.direction = Compass.get_left_turn_direction @robot.direction
	end
end