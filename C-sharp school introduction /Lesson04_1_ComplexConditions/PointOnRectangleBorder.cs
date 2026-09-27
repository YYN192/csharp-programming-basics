namespace C_sharp_school_introduction.Lesson04_1_ComplexConditions;

// Example: Point on a Rectangle Border
// Read x1, y1, x2, y2 (a rectangle) and x, y (a point).
// Print "Border" if the point lies on one of the sides, otherwise "Inside / Outside".
public static class PointOnRectangleBorder
{
    public static void Run()
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());
        var x = double.Parse(Console.ReadLine());
        var y = double.Parse(Console.ReadLine());

        // Named true/false (bool) variables make the check easy to read
        var onLeftOrRightSide = (x == x1 || x == x2) && y >= y1 && y <= y2;
        var onTopOrBottomSide = (y == y1 || y == y2) && x >= x1 && x <= x2;

        if (onLeftOrRightSide || onTopOrBottomSide)
        {
            Console.WriteLine("Border");
        }
        else
        {
            Console.WriteLine("Inside / Outside");
        }
    }
}
