using System;
public static class Clock
{
    public static int Past(int h, int m, int s)
    {

        int milliseconds = 0;

        if (h <= 23 && h >= 0)
        {
            milliseconds = milliseconds + h * 3600000;
        }

        if (m >= 0 && m <= 59)
        {
            milliseconds = milliseconds + m * 60000;
        }

        if (s >= 0 && s <= 59)
        {
            milliseconds = milliseconds + s * 1000;
        }

        return milliseconds;
    }
}

// Clock shows h hours, m minutes and s seconds after midnight.

// Your task is to write a function which returns the time since midnight in milliseconds.

// Example:
// h = 0
// m = 1
// s = 1

// result = 61000
// Input constraints:

// 0 <= h <= 23
// 0 <= m <= 59
// 0 <= s <= 59