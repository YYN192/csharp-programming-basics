namespace C_sharp_school_introduction.Lesson06_2_NestedLoopsExam;

// Exam problem: Draw a Fort
// Read n and draw a fort that is 2 * n columns wide and n rows high. Example for n = 5:
// /^^\__/^^\
// |        |
// |        |
// |   __   |
// \__/  \__/
public static class Fort
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        var towerWidth = n / 2;
        var middleWidth = 2 * n - 2 * towerWidth - 4;

        // Roof
        var tower = "/" + new string('^', towerWidth) + "\\";
        Console.WriteLine(tower + new string('_', middleWidth) + tower);

        // Walls
        for (int row = 0; row < n - 3; row++)
        {
            Console.WriteLine("|" + new string(' ', 2 * n - 2) + "|");
        }

        // The row with the gate on top
        var sideSpaces = new string(' ', towerWidth + 1);
        Console.WriteLine("|" + sideSpaces + new string('_', middleWidth) + sideSpaces + "|");

        // Bottom
        var towerBottom = "\\" + new string('_', towerWidth) + "/";
        Console.WriteLine(towerBottom + new string(' ', middleWidth) + towerBottom);
    }
}
