namespace C_sharp_school_introduction.Lesson11_TricksAndHacks;

// Trick: Debugging
// Put a breakpoint on the Console.WriteLine line (click left of the line number in Rider),
// then start with Debug. The program stops there every time, and you can watch i change.
// Press F8 (Step Over in Rider) to go line by line.
public static class DebuggingLoop
{
    public static void Run()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(i);
        }
    }
}
