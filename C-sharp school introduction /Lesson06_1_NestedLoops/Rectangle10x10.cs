namespace C_sharp_school_introduction.Lesson06_1_NestedLoops;

// Example: Rectangle of 10 x 10 Stars
// Print 10 lines with 10 stars on each line.
public static class Rectangle10x10
{
    public static void Run()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(new string('*', 10));
        }
    }
}
