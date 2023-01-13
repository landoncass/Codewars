// Given a string made of digits [0-9], return a string where each digit is repeated a number of times equals to its value.

// Examples
// explode("312")
// should return :

// "333122"
// explode("102269")
// should return :

// "12222666666999999999"

using System;
using System.Linq;
using System.Collections.Generic;

public class Digits
{
    public static string Explode(string s)
    {
        // Insert your solution here

        char[] charArray = s.ToCharArray();
        var newNumber = new List<int>();

        foreach (var num in charArray)
        {

            var count = Int32.Parse(num.ToString());

            for (var i = 0; i < count; i++)
            {
                newNumber.Add(count);
            }
        }

        string newString = String.Join("", newNumber);
        return newString;
    }
}