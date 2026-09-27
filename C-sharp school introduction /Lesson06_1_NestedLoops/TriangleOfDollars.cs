namespace C_sharp_school_introduction.Lesson06_1_NestedLoops;

// Example: Triangle of Dollars
// Read n and print a triangle: 1 dollar on the 1st row, 2 on the 2nd row, ... n on the last row.
// The number of dollars on a row is the same as the row number.
public static class TriangleOfDollars
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            Console.Write("$");
            for (int col = 1; col < row; col++)
            {
                Console.Write(" $");
            }
            Console.WriteLine();
        }
    }
}
