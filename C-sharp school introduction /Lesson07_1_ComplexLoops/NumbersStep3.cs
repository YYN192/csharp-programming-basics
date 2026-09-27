namespace C_sharp_school_introduction.Lesson07_1_ComplexLoops;

// Example: Numbers from 1 to N with Step 3
// Read n and print 1, 4, 7, 10, ... up to n. The loop goes up by 3 each time (i += 3).
public static class NumbersStep3
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i += 3)
        {
            Console.WriteLine(i);
        }
    }
}
