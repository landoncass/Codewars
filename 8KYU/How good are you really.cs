public class Kata
{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        var classPointSum = 0;
        foreach (var classPoint in ClassPoints)
        {
            classPointSum = classPointSum + classPoint;
        }
        var classPointAvg = classPointSum / ClassPoints.Length;
        return YourPoints > classPointAvg;
    }
}
// P: work out the average of the test scores by summing the scores together and dividing by the number of scores
//    then compare YourPoints to the average
// E: ClassPoints and YourPoints
// Data: the array of the students scores
//       YourPoints
//       the if statement (the boolean)
//       the average of the class points
// Alogrithm: add class points together
//            count the number of items in class points’ array
//            find the average by dividing the sum by the number of items in the array
//            return if YourPoints > average