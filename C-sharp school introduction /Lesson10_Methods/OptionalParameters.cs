namespace C_sharp_school_introduction.Lesson10_Methods;

// Example: Optional Parameters
// A parameter can have a default value. Then we may skip it when we call the method.
public static class OptionalParameters
{
    public static void Run()
    {
        PrintNumbers(5, 10);          // from 5 to 10
        PrintNumbers(15);             // from 15 to 100 (end uses its default value)
        PrintNumbers();               // from 0 to 100 (both use their default values)
        PrintNumbers(end: 40, start: 35);  // we can name the parameters
    }

    private static void PrintNumbers(int start = 0, int end = 100)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
