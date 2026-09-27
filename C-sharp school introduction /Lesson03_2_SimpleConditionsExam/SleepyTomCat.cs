namespace C_sharp_school_introduction.Lesson03_2_SimpleConditionsExam;

// Exam problem: Sleepy Tom Cat
// Tom must play at most 30 000 minutes per year to sleep well.
// On work days his owner plays with him 63 minutes, on holidays 127 minutes. A year has 365 days.
// Read the number of holidays and print if Tom sleeps well and the difference in hours and minutes.
public static class SleepyTomCat
{
    public static void Run()
    {
        var holidays = int.Parse(Console.ReadLine());
        var workDays = 365 - holidays;

        var playMinutes = workDays * 63 + holidays * 127;
        var difference = Math.Abs(30000 - playMinutes);
        var hours = difference / 60;
        var minutes = difference % 60;

        if (playMinutes > 30000)
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
        }
        else
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
        }
    }
}
