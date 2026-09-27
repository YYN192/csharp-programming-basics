namespace C_sharp_school_introduction.Lesson04_1_ComplexConditions;

// Example: Point in a Rectangle
// Read x1, y1, x2, y2 (a rectangle) and x, y (a point).
// Print "Inside" if the point is inside the rectangle (the border counts), otherwise "Outside".
public static class PointInRectangle
{
    public static void Run()
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());
        var x = double.Parse(Console.ReadLine());
        var y = double.Parse(Console.ReadLine());

        if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Outside");
        }
    }
}
