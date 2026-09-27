namespace C_sharp_school_introduction.Lesson06_2_NestedLoopsExam;

// Exam problem: Arrow
// Read an odd number n and draw an arrow pointing down. Example for n = 5:
// ..#####..
// ..#...#..
// ..#...#..
// ..#...#..
// ###...###
// .#.....#.
// ..#...#..
// ...#.#...
// ....#....
public static class Arrow
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var sideDots = new string('.', n / 2);

        // Top of the arrow
        Console.WriteLine(sideDots + new string('#', n) + sideDots);

        // The body
        for (int row = 0; row < n - 2; row++)
        {
            Console.WriteLine(sideDots + "#" + new string('.', n - 2) + "#" + sideDots);
        }

        // The wide row where the head starts
        var wing = new string('#', n / 2 + 1);
        Console.WriteLine(wing + new string('.', n - 2) + wing);

        // The head: the two sides come closer until they meet
        for (int outside = 1; outside <= n - 1; outside++)
        {
            var outsideDots = new string('.', outside);
            var inside = 2 * n - 3 - 2 * outside;

            if (inside < 0)
            {
                Console.WriteLine(outsideDots + "#" + outsideDots);
            }
            else
            {
                Console.WriteLine(outsideDots + "#" + new string('.', inside) + "#" + outsideDots);
            }
        }
    }
}
