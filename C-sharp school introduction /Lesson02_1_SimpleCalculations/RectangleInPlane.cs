namespace C_sharp_school_introduction.Lesson02_1_SimpleCalculations;

// Problem: Rectangle Area in the Plane
// A rectangle is given by two opposite corners (x1, y1) and (x2, y2).
// Print its area and its perimeter, each on a new line.
public static class RectangleInPlane
{
    public static void Run()
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());

        // The bigger x minus the smaller x gives the width. Same for the height.
        var width = Math.Max(x1, x2) - Math.Min(x1, x2);
        var height = Math.Max(y1, y2) - Math.Min(y1, y2);

        Console.WriteLine(width * height);
        Console.WriteLine(2 * (width + height));
    }
}
