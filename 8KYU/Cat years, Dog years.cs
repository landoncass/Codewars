public class Dinglemouse
{

    public static int[] humanYearsCatYearsDogYears(int humanYears)
    {
        var catYears = 0;
        var dogYears = 0;
        if (humanYears == 1)
        {
            catYears = 15;
            dogYears = 15;
        }
        else if (humanYears == 2)
        {
            catYears = 24;
            dogYears = 24;
        }
        else
        {
            catYears = 24 + (4 * (humanYears - 2));
            dogYears = 24 + (5 * (humanYears - 2));
        }
        return new int[] { humanYears, catYears, dogYears };
    }

}
/* PROBLEM: Return the age of a cat and a dog with their respective ages.
EXAMPLES : 1 HUMAN YEAR AND 15 CATS YEAR AND 15 DOG YEARS
DATA: HUMAN YEARS / CAT YEARS / DOG YEARS
ALGORITHM: Create a variable called catYears that uses an if else statement with given years
           Create a variable called dogYears that uses an if else statement with the given years

*/ 