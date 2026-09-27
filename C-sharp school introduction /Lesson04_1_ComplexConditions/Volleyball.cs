namespace C_sharp_school_introduction.Lesson04_1_ComplexConditions;

// Problem: Volleyball
// Vladi plays volleyball:
//  - on 3/4 of the Saturdays he spends in Sofia (a year has 48 weekends)
//  - on 2/3 of the holidays
//  - on every weekend he goes to his home town (h weekends)
//  - in a leap year he plays 15% more
// Read "leap" or "normal", the holidays p and the home town weekends h.
// Print how many times he played (rounded down).
public static class Volleyball
{
    public static void Run()
    {
        var year = Console.ReadLine();
        var holidays = int.Parse(Console.ReadLine());
        var homeTownWeekends = int.Parse(Console.ReadLine());

        var sofiaWeekends = 48 - homeTownWeekends;
        var gamesInSofia = sofiaWeekends * 3.0 / 4;
        var gamesOnHolidays = holidays * 2.0 / 3;
        var totalGames = gamesInSofia + gamesOnHolidays + homeTownWeekends;

        if (year == "leap")
        {
            totalGames = totalGames * 1.15;
        }

        Console.WriteLine(Math.Floor(totalGames));
    }
}
