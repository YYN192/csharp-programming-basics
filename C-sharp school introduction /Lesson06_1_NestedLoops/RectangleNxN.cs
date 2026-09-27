namespace C_sharp_school_introduction.Lesson06_1_NestedLoops;

// Example: Rectangle of N x N Stars
// Read n and print n lines with n stars on each line.
// Here we use nested loops: a loop for the rows, and inside it a loop for the columns.
public static class RectangleNxN
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= n; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
