namespace C_sharp_school_introduction.Lesson05_1_Loops;

// Example: Even / Odd Sum
// Read n numbers. Compare the sum of the numbers on even positions with the sum on odd positions.
// Equal -> "Yes" and "Sum = ...", not equal -> "No" and "Diff = ..."
public static class EvenOddSum
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var evenSum = 0;
        var oddSum = 0;

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenSum = evenSum + number;
            }
            else
            {
                oddSum = oddSum + number;
            }
        }

        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {evenSum}");
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
        }
    }
}
