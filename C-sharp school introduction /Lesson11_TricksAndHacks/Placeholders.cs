namespace C_sharp_school_introduction.Lesson11_TricksAndHacks;

// Trick: Printing with Placeholders
// {0} is replaced by the first value after the text, {1} by the second, and so on.
// A placeholder can be used more than once.
// The newer way is string interpolation: put $ before the text and the variables inside { }.
public static class Placeholders
{
    public static void Run()
    {
        var text = "some text";
        var number = 5;

        Console.WriteLine("{0}", text);
        Console.WriteLine("{0} {1} {0}", text, number);

        // The same with string interpolation
        Console.WriteLine($"{text} {number} {text}");
    }
}
