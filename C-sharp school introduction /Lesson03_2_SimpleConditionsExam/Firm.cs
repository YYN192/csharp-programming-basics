namespace C_sharp_school_introduction.Lesson03_2_SimpleConditionsExam;

// Exam problem: Firm
// A firm needs some hours for a project and has some days.
// 10% of the days are for training, so nobody works on the project then.
// A normal work day is 8 hours. Each overtime worker adds 2 hours every day.
// Print if the time is enough and how many hours are left or missing (rounded down).
public static class Firm
{
    public static void Run()
    {
        var neededHours = int.Parse(Console.ReadLine());
        var days = int.Parse(Console.ReadLine());
        var overtimeWorkers = int.Parse(Console.ReadLine());

        var workDays = days * 0.90;
        var normalHours = workDays * 8;
        var overtimeHours = overtimeWorkers * 2 * days;
        var totalHours = Math.Floor(normalHours + overtimeHours);

        if (totalHours >= neededHours)
        {
            Console.WriteLine($"Yes!{totalHours - neededHours} hours left.");
        }
        else
        {
            Console.WriteLine($"Not enough time!{neededHours - totalHours} hours needed.");
        }
    }
}
