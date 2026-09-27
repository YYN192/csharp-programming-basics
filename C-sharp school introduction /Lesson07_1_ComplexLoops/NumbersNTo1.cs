namespace C_sharp_school_introduction.Lesson07_1_ComplexLoops;

// Example: Numbers from N down to 1
// Read n and print n, n - 1, ..., 2, 1. The loop goes down by 1 each time (i--).
public static class NumbersNTo1
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = n; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}
