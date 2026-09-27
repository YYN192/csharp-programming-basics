namespace C_sharp_school_introduction.Lesson08_1_ExamPreparation;

// Exam problem: Perfect Diamond
// Read n and draw a diamond like this for n = 3:
//   *
//  *-*
// *-*-*
//  *-*
//   *
public static class PerfectDiamond
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        // Top part (with the middle row)
        for (int row = 1; row <= n; row++)
        {
            Console.Write(new string(' ', n - row));
            Console.Write("*");
            for (int i = 1; i < row; i++)
            {
                Console.Write("-*");
            }
            Console.WriteLine();
        }

        // Bottom part
        for (int row = n - 1; row >= 1; row--)
        {
            Console.Write(new string(' ', n - row));
            Console.Write("*");
            for (int i = 1; i < row; i++)
            {
                Console.Write("-*");
            }
            Console.WriteLine();
        }
    }
}
