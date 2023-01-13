using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        // Your code here
        char[] chars = str.ToCharArray();
        for (var i = 0; i < chars.Length; i++)
        {
            if (chars[i] == 'a')
            {
                vowelCount = vowelCount + 1;
            }
            else if (chars[i] == 'e')
            {
                vowelCount = vowelCount + 1;
            }
            else if (chars[i] == 'i')
            {
                vowelCount = vowelCount + 1;
            }
            else if (chars[i] == 'o')
            {
                vowelCount = vowelCount + 1;
            }
            else if (chars[i] == 'u')
            {
                vowelCount = vowelCount + 1;
            }
        }
        return vowelCount;
    }
}

// Return the number (count) of vowels in the given string.

// We will consider a, e, i, o, u as vowels for this Kata (but not y).

// The input string will only consist of lower case letters and/or spaces.