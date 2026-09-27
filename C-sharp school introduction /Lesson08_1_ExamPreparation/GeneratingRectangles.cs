namespace C_sharp_school_introduction.Lesson08_1_ExamPreparation;

// Exam problem: Generating Rectangles
// Read n and a minimum area m. Print all rectangles with whole coordinates from -n to n
// and an area of at least m, in the format: (left, top) (right, bottom) -> area
// If there are none, print "No".
public static class GeneratingRectangles
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var minArea = int.Parse(Console.ReadLine());
        var found = false;

        for (int left = -n; left <= n; left++)
        {
            for (int top = -n; top <= n; top++)
            {
                for (int right = left + 1; right <= n; right++)
                {
                    for (int bottom = top + 1; bottom <= n; bottom++)
                    {
                        var area = (right - left) * (bottom - top);
                        if (area >= minArea)
                        {
                            Console.WriteLine($"({left}, {top}) ({right}, {bottom}) -> {area}");
                            found = true;
                        }
                    }
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No");
        }
    }
}
