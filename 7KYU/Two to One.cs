// Take 2 strings s1 and s2 including only letters from a to z. Return a new sorted string, the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.

// Examples:
// a = "xyaabbbccccdefww"
// b = "xxxxyyyyabklmopq"
// longest(a, b) -> "abcdefklmopqwxy"

// a = "abcdefghijklmnopqrstuvwxyz"
// longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"




using System;
using System.Text;
using System.Linq;

public class TwoToOne
{

    public static string Longest(string s1, string s2)
    {
        StringBuilder newString = new StringBuilder("", 100);
        foreach (char c in s1)
        {
            while (newString.ToString().Contains(c) == false)
            {
                newString.Append(new char[] { c });
            }
        }
        foreach (char ch in s2)
        {
            while (newString.ToString().Contains(ch) == false)
            {
                newString.Append(new char[] { ch });
            }
        }

        var stringToReturn = String.Concat(newString.ToString().OrderBy(b => b));
        return stringToReturn;
    }
}
