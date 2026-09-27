namespace C_sharp_school_introduction.Lesson08_1_ExamPreparation;

// Exam problem: Rectangle with Stars in the Center
// Read n and draw a rectangle 2 * n wide with two stars in the middle, like this for n = 4:
// %%%%%%%%
// %      %
// %  **  %
// %      %
// %%%%%%%%
public static class RectangleWithStars
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var width = 2 * n;

        // Top line
        Console.WriteLine(new string('%', width));

        // Empty rows above the stars
        var emptyRows = (n - 1) / 2;
        for (int row = 0; row < emptyRows; row++)
        {
            Console.WriteLine("%" + new string(' ', width - 2) + "%");
        }

        // The row with the stars
        var spaces = new string(' ', (width - 4) / 2);
        Console.WriteLine("%" + spaces + "**" + spaces + "%");

        // Empty rows below the stars
        for (int row = 0; row < emptyRows; row++)
        {
            Console.WriteLine("%" + new string(' ', width - 2) + "%");
        }

        // Bottom line
        Console.WriteLine(new string('%', width));
    }
}
