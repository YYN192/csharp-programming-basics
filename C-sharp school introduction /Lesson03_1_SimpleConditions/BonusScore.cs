namespace C_sharp_school_introduction.Lesson03_1_SimpleConditions;

// Problem: Bonus Score
// Read a whole number of points and add bonus points to it:
//  - up to 100 points (including)  -> 5 bonus points
//  - more than 100                 -> 20% of the points
//  - more than 1000                -> 10% of the points
//  - extra: even number -> +1, number ending in 5 -> +2
// Print the bonus points and then the total points.
public static class BonusScore
{
    public static void Run()
    {
        var points = int.Parse(Console.ReadLine());
        var bonus = 0.0;

        if (points <= 100)
        {
            bonus = 5;
        }
        else if (points > 1000)
        {
            bonus = points * 0.10;
        }
        else
        {
            bonus = points * 0.20;
        }

        if (points % 2 == 0)
        {
            bonus = bonus + 1;
        }
        else if (points % 10 == 5)
        {
            bonus = bonus + 2;
        }

        Console.WriteLine(bonus);
        Console.WriteLine(points + bonus);
    }
}
