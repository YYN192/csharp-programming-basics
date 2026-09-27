namespace C_sharp_school_introduction.Lesson06_1_NestedLoops;

// Problem: Rhombus of Stars
// Read n and print a rhombus of stars, like this for n = 3:
//   *
//  * *
// * * *
//  * *
//   *
public static class RhombusOfStars
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        // Top part (with the middle row): row 1 to n
        for (int row = 1; row <= n; row++)
        {
            Console.Write(new string(' ', n - row));
            Console.Write("*");
            for (int i = 1; i < row; i++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }

        // Bottom part: row n - 1 down to 1
        for (int row = n - 1; row >= 1; row--)
        {
            Console.Write(new string(' ', n - row));
            Console.Write("*");
            for (int i = 1; i < row; i++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
    }
}
