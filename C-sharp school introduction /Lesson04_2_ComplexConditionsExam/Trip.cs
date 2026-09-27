namespace C_sharp_school_introduction.Lesson04_2_ComplexConditionsExam;

// Exam problem: Trip
// Read a budget and a season ("summer" or "winter") and print where the programmer goes
// and how much he spends:
//  - up to 100 leva:  Bulgaria, summer: camp for 30%, winter: hotel for 70%
//  - up to 1000 leva: Balkans,  summer: camp for 40%, winter: hotel for 80%
//  - more:            Europe, always a hotel for 90%
public static class Trip
{
    public static void Run()
    {
        var budget = double.Parse(Console.ReadLine());
        var season = Console.ReadLine();

        var destination = "";
        var place = "";
        var spent = 0.0;

        if (budget <= 100)
        {
            destination = "Bulgaria";
            if (season == "summer")
            {
                place = "Camp";
                spent = budget * 0.30;
            }
            else
            {
                place = "Hotel";
                spent = budget * 0.70;
            }
        }
        else if (budget <= 1000)
        {
            destination = "Balkans";
            if (season == "summer")
            {
                place = "Camp";
                spent = budget * 0.40;
            }
            else
            {
                place = "Hotel";
                spent = budget * 0.80;
            }
        }
        else
        {
            destination = "Europe";
            place = "Hotel";
            spent = budget * 0.90;
        }

        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine($"{place} - {spent:f2}");
    }
}
