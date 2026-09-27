namespace C_sharp_school_introduction.Lesson08_1_ExamPreparation;

// Exam problem: Triangle Area in the Plane
// A triangle is given by its 3 corners (x1, y1), (x2, y2), (x3, y3).
// The last two corners are on the same horizontal line (y2 == y3). Print the area.
public static class TriangleAreaInPlane
{
    public static void Run()
    {
        var x1 = int.Parse(Console.ReadLine());
        var y1 = int.Parse(Console.ReadLine());
        var x2 = int.Parse(Console.ReadLine());
        var y2 = int.Parse(Console.ReadLine());
        var x3 = int.Parse(Console.ReadLine());
        var y3 = int.Parse(Console.ReadLine());

        var side = Math.Abs(x3 - x2);
        var height = Math.Abs(y1 - y2);
        var area = side * height / 2.0;

        Console.WriteLine(area);
    }
}
