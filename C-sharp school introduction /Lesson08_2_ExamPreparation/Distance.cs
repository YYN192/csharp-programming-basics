namespace C_sharp_school_introduction.Lesson08_2_ExamPreparation;

// Exam problem: Distance
// A car starts with some speed (km/h) and drives for t1 minutes.
// Then it goes 10% faster for t2 minutes. Then it goes 5% slower for t3 minutes.
// Print the total kilometers with 2 digits. (Minutes / 60 = hours)
public static class Distance
{
    public static void Run()
    {
        var speed = double.Parse(Console.ReadLine());
        var minutes1 = int.Parse(Console.ReadLine());
        var minutes2 = int.Parse(Console.ReadLine());
        var minutes3 = int.Parse(Console.ReadLine());

        var distance1 = speed * minutes1 / 60;

        speed = speed * 1.10;  // 10% faster
        var distance2 = speed * minutes2 / 60;

        speed = speed * 0.95;  // 5% slower
        var distance3 = speed * minutes3 / 60;

        var totalDistance = distance1 + distance2 + distance3;
        Console.WriteLine($"{totalDistance:f2}");
    }
}
