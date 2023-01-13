// Your team is writing a fancy new text editor and you've been tasked with implementing the line numbering.

// Write a function which takes a list of strings and returns each line prepended by the correct number.

// The numbering starts at 1. The format is n: string. Notice the colon and space in between.

// Examples: (Input --> Output)

// [] --> []
// ["a", "b", "c"] --> ["1: a", "2: b", "3: c"]

using System.Collections.Generic;
using System.Linq;

public class LineNumbering
{
    public static List<string> Number(List<string> lines)
    {
        //your code goes here
        var newList = new List<string>();
        for (var i = 0; i < lines.Count; i++)
        {
            newList.Add($"{i + 1}: {lines[i]}");
        }
        return newList;

    }
}