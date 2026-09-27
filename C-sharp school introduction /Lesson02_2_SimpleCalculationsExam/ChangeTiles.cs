namespace C_sharp_school_introduction.Lesson02_2_SimpleCalculationsExam;

// Exam problem: Change Tiles
// A square ground with side N must be covered with tiles W x L, except for a bench M x O.
// Each tile takes 0.2 minutes to put down.
// Print how many tiles are needed and how many minutes it takes.
public static class ChangeTiles
{
    public static void Run()
    {
        var groundSide = double.Parse(Console.ReadLine());
        var tileWidth = double.Parse(Console.ReadLine());
        var tileLength = double.Parse(Console.ReadLine());
        var benchWidth = double.Parse(Console.ReadLine());
        var benchLength = double.Parse(Console.ReadLine());

        var areaToCover = groundSide * groundSide - benchWidth * benchLength;
        var tileArea = tileWidth * tileLength;

        var tilesNeeded = areaToCover / tileArea;
        var minutes = tilesNeeded * 0.2;

        Console.WriteLine(tilesNeeded);
        Console.WriteLine(minutes);
    }
}
