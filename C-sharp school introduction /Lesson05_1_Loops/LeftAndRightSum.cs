namespace C_sharp_school_introduction.Lesson05_1_Loops;

// Example: Left and Right Sum
// Read n, then 2 * n numbers. Compare the sum of the first n (left) with the sum of the next n (right).
// Equal -> "Yes, sum = ...", not equal -> "No, diff = ..."
public static class LeftAndRightSum
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        var leftSum = 0;
        for (int i = 0; i < n; i++)
        {
            leftSum = leftSum + int.Parse(Console.ReadLine());
        }

        var rightSum = 0;
        for (int i = 0; i < n; i++)
        {
            rightSum = rightSum + int.Parse(Console.ReadLine());
        }

        if (leftSum == rightSum)
        {
            Console.WriteLine($"Yes, sum = {leftSum}");
        }
        else
        {
            Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
        }
    }
}
