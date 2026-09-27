namespace C_sharp_school_introduction.Lesson09_1_ChampionsPart1;

// Champions problem: Magic Dates
// The "weight" of a date like 17-03-2007 is: take all its digits (17032007),
// multiply every digit with every digit after it, and add everything up.
// Read a start year, an end year and a magic weight.
// Print all dates between the two years (including them) with that weight, or "No".
public static class MagicDates
{
    public static void Run()
    {
        var startYear = int.Parse(Console.ReadLine());
        var endYear = int.Parse(Console.ReadLine());
        var magicWeight = int.Parse(Console.ReadLine());
        var found = false;

        // DateTime knows how many days each month has (and about leap years too)
        var date = new DateTime(startYear, 1, 1);
        while (date.Year <= endYear)
        {
            var digits = date.ToString("ddMMyyyy");
            var weight = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                for (int j = i + 1; j < digits.Length; j++)
                {
                    // A digit character minus '0' gives the digit as a number: '7' - '0' = 7
                    weight = weight + (digits[i] - '0') * (digits[j] - '0');
                }
            }

            if (weight == magicWeight)
            {
                Console.WriteLine(date.ToString("dd-MM-yyyy"));
                found = true;
            }

            date = date.AddDays(1);
        }

        if (!found)
        {
            Console.WriteLine("No");
        }
    }
}
