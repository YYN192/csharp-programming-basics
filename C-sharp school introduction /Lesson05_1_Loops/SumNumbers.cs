namespace C_sharp_school_introduction.Lesson05_1_Loops;

// Example: Summing Up Numbers
// Read n, then read n whole numbers and print their sum.
public static class SumNumbers
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var sum = 0;

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());
            sum = sum + number;
        }

        Console.WriteLine(sum);
    }
}
