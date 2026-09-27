namespace C_sharp_school_introduction.Lesson06_2_NestedLoopsExam;

// Exam problem: "Stop" Sign
// Read n and draw a STOP sign. Example for n = 3:
// ...._______....
// ...//_____\\...
// ..//_______\\..
// .//_________\\.
// //___STOP!___\\
// \\___________//
// .\\_________//.
// ..\\_______//..
public static class StopSign
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        // First line
        var outsideDots = new string('.', n + 1);
        Console.WriteLine(outsideDots + new string('_', 2 * n + 1) + outsideDots);

        // Top part: fewer dots and more underscores on each row
        var underscores = 2 * n - 1;
        for (int dots = n; dots >= 1; dots--)
        {
            var dotsText = new string('.', dots);
            Console.WriteLine(dotsText + "//" + new string('_', underscores) + "\\\\" + dotsText);
            underscores = underscores + 2;
        }

        // Middle line with the text
        var sideUnderscores = new string('_', 2 * n - 3);
        Console.WriteLine("//" + sideUnderscores + "STOP!" + sideUnderscores + "\\\\");

        // Bottom part: more dots and fewer underscores on each row
        underscores = 4 * n - 1;
        for (int dots = 0; dots < n; dots++)
        {
            var dotsText = new string('.', dots);
            Console.WriteLine(dotsText + "\\\\" + new string('_', underscores) + "//" + dotsText);
            underscores = underscores - 2;
        }
    }
}
