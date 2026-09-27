namespace C_sharp_school_introduction.Lesson05_1_Loops;

// Example: Max Number
// Read n, then read n whole numbers and print the biggest one.
public static class MaxNumber
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        // Start with the smallest possible int, so any number we read will be bigger
        var max = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine(max);
    }
}
