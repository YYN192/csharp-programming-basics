namespace C_sharp_school_introduction.Lesson10_Methods;

// Example: Print a Triangle
// Read n and print a triangle of numbers, like this for n = 3:
// 1
// 1 2
// 1 2 3
// 1 2
// 1
public static class PrintTriangle
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        // Top part
        for (int i = 1; i < n; i++)
        {
            PrintLine(1, i);
        }

        // Middle line
        PrintLine(1, n);

        // Bottom part
        for (int i = n - 1; i >= 1; i--)
        {
            PrintLine(1, i);
        }
    }

    // Prints the numbers from start to end on one line
    private static void PrintLine(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(i);
            if (i < end)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
