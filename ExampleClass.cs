using FluentAssertions;

namespace application_structure
{
    public class ExampleClass
    {
        public void additionMethod() {
            var first = 3;
            var second = 7;
            var result = first + second;
        
            result.Should().Be(10);
        }
    }
}