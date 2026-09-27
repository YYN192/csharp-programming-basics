namespace C_sharp_school_introduction.Lesson05_1_Loops;

// Problem: Equal Pairs
// Read n, then 2 * n numbers. The 1st and 2nd make a pair, the 3rd and 4th make a pair, and so on.
// The value of a pair is the sum of its two numbers.
// All pairs equal -> "Yes, value=..."
// Otherwise       -> "No, maxdiff=..." (the biggest difference between two pairs next to each other)
public static class EqualPairs
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var previousValue = 0;
        var currentValue = 0;
        var maxDiff = 0;

        for (int i = 0; i < n; i++)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());

            previousValue = currentValue;
            currentValue = first + second;

            // The first pair has no pair before it, so we compare from the second pair on
            if (i > 0)
            {
                var diff = Math.Abs(currentValue - previousValue);
                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }
            }
        }

        if (maxDiff == 0)
        {
            Console.WriteLine($"Yes, value={currentValue}");
        }
        else
        {
            Console.WriteLine($"No, maxdiff={maxDiff}");
        }
    }
}
