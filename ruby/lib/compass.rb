class Compass
  @directions = [:N, :E, :S, :W]

  def self.get_right_turn_direction(direction)
    return @directions.first if direction == @directions.last
    @directions[@directions.index(direction) + 1]
  end

  def self.get_left_turn_direction(direction)
    return @directions.last if direction == @directions.first
    @directions[@directions.index(direction) - 1]
  end

  def self.get_opposite_direction(direction)
    direction_to_the_right = get_right_turn_direction direction
    get_right_turn_direction direction_to_the_right
  end
end