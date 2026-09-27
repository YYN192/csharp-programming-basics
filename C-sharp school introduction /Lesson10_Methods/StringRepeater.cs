namespace C_sharp_school_introduction.Lesson10_Methods;

// Problem: String Repeater
// Read a text and a number n and print the text repeated n times.
public static class StringRepeater
{
    public static void Run()
    {
        var text = Console.ReadLine();
        var count = int.Parse(Console.ReadLine());

        Console.WriteLine(RepeatString(text, count));
    }

    private static string RepeatString(string text, int count)
    {
        var result = "";
        for (int i = 0; i < count; i++)
        {
            result = result + text;
        }
        return result;
    }
}
