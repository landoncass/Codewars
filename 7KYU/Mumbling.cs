// This time no story, no theory. The examples below show you how to write function accum:

// Examples:
// accum("abcd") -> "A-Bb-Ccc-Dddd"
// accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
// accum("cwAt") -> "C-Ww-Aaa-Tttt"
// The parameter of accum is a string which includes only letters from a..z and A..Z.

using System;
using System.Linq;
using System.Collections.Generic;
public class Accumul
{
    public static String Accum(string s)
    {
        var characters = s.ToCharArray();
        var exploded = new List<string>();
        for (var i = 0; i < characters.Length; i++)
        {
            var character = characters[i];
            var str = character.ToString();
            var letter = new List<string>();
            for (var j = 0; j <= i; j++)
            {
                if (j == 0)
                {
                    letter.Add(str.ToUpper());
                }
                else
                {
                    letter.Add(str.ToLower());
                }
            }
            exploded.Add(string.Join("", letter));
        }
        return string.Join("-", exploded);
    }
}