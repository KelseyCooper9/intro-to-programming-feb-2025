
using Banking.Domain;
namespace Banking.Tests.Syntax;
    public class Types
{
    string Name = "Bob";  //2 first class citizens- can have a name- must be a class or a struct and is decided by where they live
    [Fact]
    public void DeclaringVariables()
    {
        //type identifier [=initializer]
        var age = 55; //same thing as system.int32 //structs are value types

        //var has to be assigned 
        //decimal float point varible a little safter than double (decimal Pay = 18.23M) *deciaMal M syntax to convert
        // a variable in a strict typed language can't change its type unlike python
        // only can use var inside of a method 
        Assert.Equal(55, age);
        Assert.Equal("Bob", Name);
        //value types defined by a struct- faster
        //reference types defined by a class- has to be added to heap- less fast 
    }
    // end of method- variables pop off (struct)

    [Fact]
    public void AnotherThing()
    {
        Assert.Equal("Bob", this.Name);
    }
}

