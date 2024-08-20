using FluentAssertions;

namespace StrykerDemo.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(1, false)]
    [TestCase(6, true)]
    [TestCase(11, false)]
    [TestCase(5, false)]
    [TestCase(10, false)]
    public void IsGreaterThan5AndLessThan10_ReturnsExpectedValues(int input, bool expectedResult)
    {
        // Act
        var result = DemoClass.IsGreaterThan5AndLessThan10(input);
        
        // Assert
        result.Should().Be(expectedResult);
    }
}