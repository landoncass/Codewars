// Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.

// Examples input/output:

// XO("ooxx") => true
// XO("xooxx") => false
// XO("ooxXm") => true
// XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
// XO("zzoo") => false

using System.Linq;
using System;
public static class Kata
{
    public static bool XO(string input)
    {
        var xCount = 0;
        var oCount = 0;
        var CharArray = input.ToCharArray();
        foreach (char c in CharArray)
        {
            if (char.ToLower(c) == 'o')
            {
                oCount += 1;
            }
            else if (char.ToLower(c) == 'x')
            {
                xCount += 1;
            }
            else if (char.ToLower(c) != 'o' && char.ToLower(c) != 'x')
            {
                xCount += 0;
                oCount += 0;
            }
            else if (char.ToLower(c) != 'o' || char.ToLower(c) != 'x')
            {
                xCount += 0;
                oCount += 0;
            }
        }

        if (xCount == oCount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}