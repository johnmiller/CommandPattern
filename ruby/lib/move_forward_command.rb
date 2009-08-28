class MoveForwardCommand
	def initialize(robot)
		@robot = robot
		@move_actions = {:N => Proc.new{|r| r.position.y += 1},
						:E => Proc.new{|r| r.position.x += 1},
						:S => Proc.new{|r| r.position.y -= 1},
						:W => Proc.new{|r| r.position.x -= 1}}
	end

	def execute
	  @move_actions[@robot.direction].call @robot
    end

    def undo
      opposite_direction = Compass.get_opposite_direction @robot.direction
      @move_actions[opposite_direction].call @robot
    end
end