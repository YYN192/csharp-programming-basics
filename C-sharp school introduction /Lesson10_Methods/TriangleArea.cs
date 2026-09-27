namespace C_sharp_school_introduction.Lesson10_Methods;

// Example: Triangle Area (a method that returns a result)
// Read the base and the height of a triangle and print its area.
public static class TriangleArea
{
    public static void Run()
    {
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());

        var area = GetTriangleArea(width, height);
        Console.WriteLine(area);
    }

    private static double GetTriangleArea(double width, double height)
    {
        return width * height / 2;
    }
}
