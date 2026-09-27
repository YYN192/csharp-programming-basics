namespace C_sharp_school_introduction.Lesson04_1_ComplexConditions;

// Lab: * Point and Rectangle (GUI app in the book)
// In the book this is a Windows Forms app that draws a rectangle and a point.
// Console version: read two corners of a rectangle (x1, y1, x2, y2) and a point (x, y),
// then print "Inside", "Outside" or "Border".
// The corners can be given in any order, so we find the left/right and bottom/top sides first.
public static class PointAndRectangleApp
{
    public static void Run()
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());
        var x = double.Parse(Console.ReadLine());
        var y = double.Parse(Console.ReadLine());

        var left = Math.Min(x1, x2);
        var right = Math.Max(x1, x2);
        var bottom = Math.Min(y1, y2);
        var top = Math.Max(y1, y2);

        var isInside = x > left && x < right && y > bottom && y < top;
        var isOutside = x < left || x > right || y < bottom || y > top;

        if (isInside)
        {
            Console.WriteLine("Inside");
        }
        else if (isOutside)
        {
            Console.WriteLine("Outside");
        }
        else
        {
            Console.WriteLine("Border");
        }
    }
}
