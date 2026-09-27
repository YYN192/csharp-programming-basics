namespace C_sharp_school_introduction.Lesson06_1_NestedLoops;

// Example: Square of Stars
// Read n and print a square of n x n stars with a space between them, like:
// * * *
// * * *
// * * *
public static class SquareOfStars
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            Console.Write("*");
            for (int col = 1; col < n; col++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
    }
}
