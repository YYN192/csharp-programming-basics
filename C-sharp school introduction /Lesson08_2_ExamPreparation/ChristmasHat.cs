namespace C_sharp_school_introduction.Lesson08_2_ExamPreparation;

// Exam problem: Christmas Hat
// Read n and draw a Christmas hat that is 4 * n + 1 wide and 2 * n + 5 high. Example for n = 4:
// ......./|\.......
// .......\|/.......
// .......***.......
// ......*-*-*......
// .....*--*--*.....
// ....*---*---*....
// ...*----*----*...
// ..*-----*-----*..
// .*------*------*.
// *-------*-------*
// *****************
// *.*.*.*.*.*.*.*.*
// *****************
public static class ChristmasHat
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var width = 4 * n + 1;
        var topDots = new string('.', 2 * n - 1);

        // The top of the hat
        Console.WriteLine(topDots + "/|\\" + topDots);
        Console.WriteLine(topDots + "\\|/" + topDots);
        Console.WriteLine(topDots + "***" + topDots);

        // The body: fewer dots and more dashes on each row
        for (int dashes = 1; dashes <= 2 * n - 1; dashes++)
        {
            var dots = new string('.', 2 * n - 1 - dashes);
            var dashesText = new string('-', dashes);
            Console.WriteLine(dots + "*" + dashesText + "*" + dashesText + "*" + dots);
        }

        // The bottom
        Console.WriteLine(new string('*', width));

        Console.Write("*");
        for (int i = 0; i < 2 * n; i++)
        {
            Console.Write(".*");
        }
        Console.WriteLine();

        Console.WriteLine(new string('*', width));
    }
}
