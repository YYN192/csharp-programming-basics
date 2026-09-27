namespace C_sharp_school_introduction.Lesson05_1_Loops;

// Example: Min Number
// Read n, then read n whole numbers and print the smallest one.
public static class MinNumber
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        // Start with the biggest possible int, so any number we read will be smaller
        var min = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());
            if (number < min)
            {
                min = number;
            }
        }

        Console.WriteLine(min);
    }
}
