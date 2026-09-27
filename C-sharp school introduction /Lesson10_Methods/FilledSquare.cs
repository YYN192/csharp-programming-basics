namespace C_sharp_school_introduction.Lesson10_Methods;

// Example: Draw a Filled Square
// Read n and draw a square like this for n = 4:
// --------
// -\/\/\/-
// -\/\/\/-
// --------
public static class FilledSquare
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        PrintHeaderRow(n);
        for (int i = 0; i < n - 2; i++)
        {
            PrintMiddleRow(n);
        }
        PrintHeaderRow(n);
    }

    private static void PrintHeaderRow(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }

    private static void PrintMiddleRow(int n)
    {
        Console.Write("-");
        for (int i = 1; i < n; i++)
        {
            Console.Write("\\/");
        }
        Console.WriteLine("-");
    }
}
