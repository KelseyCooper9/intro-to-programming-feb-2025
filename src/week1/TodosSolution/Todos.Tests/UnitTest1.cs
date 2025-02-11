using Todos.Api.utils;

namespace Todos.Tests;

public class UnitTest1
{
    [Fact] //attributes(@fact())// proves one specific thing 
    public void CanFormatKelseyCoopersName()
    {//given
        string firstName = "Kelsey", lastName = "cooper", fullName;
        var formatter = new Formatters();
        //when
        fullName = formatter.FormatName(firstName, lastName);
        //then
       Assert.Equal("cooper Kelsey", fullName);
    }
    [Theory] //multiple examples and holds true for multiple examples 
    [InlineData("Kelsey", "cooper", "cooper Kelsey")]
    [InlineData("Luke", "Skywalker", "Skywalker Luke")]
    public void CanFormatAnyName(string firstName, string lastName, string expecting)
    {
        var formatter = new Formatters();
        var fullName = formatter.FormatName(firstName, lastName);
        Assert.Equal(expecting, fullName);
    }
}
