namespace C_sharp_school_introduction.Lesson06_1_NestedLoops;

// Example: Square Frame
// Read n and print a frame of size n x n, like this for n = 4:
// + - - +
// | - - |
// | - - |
// + - - +
public static class SquareFrame
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        // Top line
        Console.Write("+ ");
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("- ");
        }
        Console.WriteLine("+");

        // Middle lines
        for (int row = 0; row < n - 2; row++)
        {
            Console.Write("| ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("|");
        }

        // Bottom line
        Console.Write("+ ");
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("- ");
        }
        Console.WriteLine("+");
    }
}
