

using System.Globalization;

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


    [Fact]
    public void SingleStringReturnsNumber()
    {
        var calculator = new Calculator();
        var result = calculator.Add("5");
        Assert.Equal(5, result);

    }

    [Theory] //forgot completely how to do theories and peeked at code s
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("3", 3)]
    [InlineData("2080", 2080)]


    public void SingleDigit(string numbers, int expected)
    {

        var calculator = new Calculator();
        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("2,2", 4)]
    [InlineData("3,2", 5)]

    public void StringWithTwoNumbers(string numbers, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }
}


