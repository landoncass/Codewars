using system.linq;

public class Kata
{
public static bool Solution(string str, string ending)
{
return collection.Where(str => ending.Any (a => str.Name.Contains(a)));
}
}

// Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).

// Examples:

// solution('abc', 'bc') // returns true
// solution('abc', 'd') // returns false
