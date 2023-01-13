using System;

public class Kata
{
    public static string Greet(string name, string owner)
    {
        if (name == owner)
        {
            return "Hello boss";
        }
        else if (name != owner)
        {
            return "Hello guest";
        }
        else
        {
            return "Please provide a name and an owner value.";
        }
    }
}

// Create a function that gives a personalized greeting. This function takes two parameters: name and owner.

// Use conditionals to return the proper message:

// case	return
// name equals owner	'Hello boss'
// otherwise	'Hello guest'