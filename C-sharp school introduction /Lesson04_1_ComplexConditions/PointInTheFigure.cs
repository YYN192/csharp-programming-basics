namespace C_sharp_school_introduction.Lesson04_1_ComplexConditions;

// * Problem: Point in the Figure
// The figure is made of 6 squares h x h and looks like an upside-down "T":
//  - a bottom rectangle: x from 0 to 3h, y from 0 to h
//  - a top rectangle:    x from h to 2h, y from h to 4h
// Read h and a point x, y and print "inside", "outside" or "border".
public static class PointInTheFigure
{
    public static void Run()
    {
        var h = int.Parse(Console.ReadLine());
        var x = int.Parse(Console.ReadLine());
        var y = int.Parse(Console.ReadLine());

        // Strictly inside one of the two rectangles (not on a wall)
        var insideBottom = x > 0 && x < 3 * h && y > 0 && y < h;
        var insideTop = x > h && x < 2 * h && y > h && y < 4 * h;

        // The line where the two rectangles touch is inside the figure too
        var onCommonSide = y == h && x > h && x < 2 * h;

        // Inside a rectangle or on its walls
        var inBottomOrOnWall = x >= 0 && x <= 3 * h && y >= 0 && y <= h;
        var inTopOrOnWall = x >= h && x <= 2 * h && y >= h && y <= 4 * h;

        if (insideBottom || insideTop || onCommonSide)
        {
            Console.WriteLine("inside");
        }
        else if (inBottomOrOnWall || inTopOrOnWall)
        {
            Console.WriteLine("border");
        }
        else
        {
            Console.WriteLine("outside");
        }
    }
}
