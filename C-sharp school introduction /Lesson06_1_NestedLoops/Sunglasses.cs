namespace C_sharp_school_introduction.Lesson06_1_NestedLoops;

// Problem: Sunglasses
// Read n and print sunglasses with size 5n x n, like this for n = 4:
// ********    ********
// *//////*||||*//////*
// *//////*    *//////*
// ********    ********
public static class Sunglasses
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        // Top frame
        Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));

        // Middle rows. The bridge |||| is on the middle row.
        for (int row = 1; row <= n - 2; row++)
        {
            var glass = "*" + new string('/', 2 * n - 2) + "*";

            if (row == (n - 1) / 2)
            {
                Console.WriteLine(glass + new string('|', n) + glass);
            }
            else
            {
                Console.WriteLine(glass + new string(' ', n) + glass);
            }
        }

        // Bottom frame
        Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
    }
}
