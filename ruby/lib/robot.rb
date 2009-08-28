class Robot
	attr_accessor :position, :direction
	
	def initialize(position, direction)
		@position = position
		@direction = direction
		@commands_executed = []
	end
	
	def execute_instruction(command)
        command.execute
		@commands_executed << command
	end
	
	def reset
		@commands_executed.reverse_each{|x| x.undo}
	end
end









