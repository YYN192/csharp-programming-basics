namespace C_sharp_school_introduction.Lesson06_1_NestedLoops;

// Problem: Diamond
// Read n and print a diamond with width n, like this for n = 5:
// --*--
// -*-*-
// *---*
// -*-*-
// --*--
public static class Diamond
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        // Top part: the outside dashes get fewer and the inside dashes get more
        for (int outside = (n - 1) / 2; outside >= 0; outside--)
        {
            var inside = n - 2 * outside - 2;
            var outsideDashes = new string('-', outside);

            if (inside < 0)
            {
                // Only one star on this row
                Console.WriteLine(outsideDashes + "*" + outsideDashes);
            }
            else
            {
                Console.WriteLine(outsideDashes + "*" + new string('-', inside) + "*" + outsideDashes);
            }
        }

        // Bottom part: the same rows, but in the opposite order
        for (int outside = 1; outside <= (n - 1) / 2; outside++)
        {
            var inside = n - 2 * outside - 2;
            var outsideDashes = new string('-', outside);

            if (inside < 0)
            {
                Console.WriteLine(outsideDashes + "*" + outsideDashes);
            }
            else
            {
                Console.WriteLine(outsideDashes + "*" + new string('-', inside) + "*" + outsideDashes);
            }
        }
    }
}
