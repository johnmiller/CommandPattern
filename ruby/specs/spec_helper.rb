dir = File.join(File.dirname(__FILE__), '..', 'lib')
  Dir[File.expand_path("#{dir}/*.rb")].uniq.each do |file|
  require file
end

require 'spec'
require 'spec/autorun'


Spec::Runner.configure do |config|

end