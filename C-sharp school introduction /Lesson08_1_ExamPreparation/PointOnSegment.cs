namespace C_sharp_school_introduction.Lesson08_1_ExamPreparation;

// Exam problem: Point on a Segment
// A segment on a line is given by its two ends: first and second. A point is on the same line.
// Print "in" or "out" and the distance from the point to the closer end of the segment.
public static class PointOnSegment
{
    public static void Run()
    {
        var first = int.Parse(Console.ReadLine());
        var second = int.Parse(Console.ReadLine());
        var point = int.Parse(Console.ReadLine());

        var left = Math.Min(first, second);
        var right = Math.Max(first, second);

        if (point >= left && point <= right)
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("out");
        }

        var distanceToLeft = Math.Abs(point - left);
        var distanceToRight = Math.Abs(point - right);
        Console.WriteLine(Math.Min(distanceToLeft, distanceToRight));
    }
}
