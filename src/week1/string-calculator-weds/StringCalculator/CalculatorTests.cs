

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }
    [Theory]
    [InlineData("5")]
    [InlineData("10")]
    [InlineData("-5")]
    public void SingleStringReturnsNumber(string number)
    {
        var calculator = new Calculator();
        var result = calculator.Add("5");
        Assert.Equal(5, result);
    }
    [Fact]
    public void AddTwoStringsTogether()
    {
        var calculator = new Calculator();
        var result = calculator.Add("5, 6");
        Assert.Equal(11, result);
    }
    [Fact]
    public void CanTakeArbitraryLength()
    {
        var calculator = new Calculator();
        var result = calculator.Add("5, 6, 7, 8");
        Assert.Equal(26, result);
    }
}
