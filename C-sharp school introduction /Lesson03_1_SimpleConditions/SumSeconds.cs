namespace C_sharp_school_introduction.Lesson03_1_SimpleConditions;

// Problem: Summing Up Seconds
// Three runners finish in some seconds each. Print their total time as "minutes:seconds".
// The seconds always have 2 digits (7 -> "07").
public static class SumSeconds
{
    public static void Run()
    {
        var first = int.Parse(Console.ReadLine());
        var second = int.Parse(Console.ReadLine());
        var third = int.Parse(Console.ReadLine());

        var totalSeconds = first + second + third;
        var minutes = totalSeconds / 60;
        var seconds = totalSeconds % 60;

        if (seconds < 10)
        {
            Console.WriteLine($"{minutes}:0{seconds}");
        }
        else
        {
            Console.WriteLine($"{minutes}:{seconds}");
        }
    }
}
