namespace Todos.Api.utils;

public class Formatters
{
    // method that takes 2 strings and returns a string 
    public string FormatName(string firstName, string lastName)
    {
        return  $"{lastName} {firstName}";
    }
}

//static dont need to create a new instance of a class - its a utility
//without static you need an object reference 
