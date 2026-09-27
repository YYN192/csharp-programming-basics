namespace C_sharp_school_introduction.Lesson06_2_NestedLoopsExam;

// Exam problem: Axe
// Read n and draw an axe that is 5 * n columns wide. Example for n = 5:
// ---------------**--------
// ---------------*-*-------
// ---------------*--*------
// ---------------*---*-----
// ---------------*----*----
// ****************----*----
// ****************----*----
// ---------------*----*----
// --------------********---
public static class Axe
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        // Top part of the blade: the gap between the two stars grows
        for (int row = 0; row < n; row++)
        {
            Console.WriteLine(new string('-', 3 * n) + "*" + new string('-', row) + "*" + new string('-', 2 * n - row - 2));
        }

        // The handle
        for (int row = 0; row < n / 2; row++)
        {
            Console.WriteLine(new string('*', 3 * n + 1) + new string('-', n - 1) + "*" + new string('-', n - 1));
        }

        // Bottom part of the blade: it gets wider, and the last row is full of stars
        for (int row = 0; row < n / 2; row++)
        {
            var leftDashes = new string('-', 3 * n - row);
            var rightDashes = new string('-', n - 1 - row);

            if (row == n / 2 - 1)
            {
                Console.WriteLine(leftDashes + new string('*', n + 1 + 2 * row) + rightDashes);
            }
            else
            {
                Console.WriteLine(leftDashes + "*" + new string('-', n - 1 + 2 * row) + "*" + rightDashes);
            }
        }
    }
}
