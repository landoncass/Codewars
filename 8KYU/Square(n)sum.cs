// Complete the square sum function so that it squares each number passed into it and then sums the results together.

// For example, for [1, 2, 2] it should return 9 because 1^2 + 2^2 + 2^2 = 9.

using system;
public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    var sum = 0;
foreach (var num in numbers)
{
  sum += (num^num);
}
return sum;
  }
}