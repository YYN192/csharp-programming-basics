namespace C_sharp_school_introduction.Lesson08_1_ExamPreparation;

// Exam problem: Point in a Figure
// The figure looks like a plus sign made of two rectangles:
//  - rectangle 1: x from 2 to 12, y from -3 to 1
//  - rectangle 2: x from 4 to 10, y from -5 to 3
// Read x and y and print "in" (the border counts as in) or "out".
public static class PointInFigure
{
    public static void Run()
    {
        var x = int.Parse(Console.ReadLine());
        var y = int.Parse(Console.ReadLine());

        var inRectangle1 = x >= 2 && x <= 12 && y >= -3 && y <= 1;
        var inRectangle2 = x >= 4 && x <= 10 && y >= -5 && y <= 3;

        if (inRectangle1 || inRectangle2)
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("out");
        }
    }
}
