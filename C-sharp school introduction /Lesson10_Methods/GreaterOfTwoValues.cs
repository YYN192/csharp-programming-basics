namespace C_sharp_school_introduction.Lesson10_Methods;

// Example: The Greater of Two Values (method overloading)
// Read a type (int, char or string) and two values of that type. Print the greater one.
// We write three methods with the same name GetMax, but with different parameters.
public static class GreaterOfTwoValues
{
    public static void Run()
    {
        var type = Console.ReadLine();

        if (type == "int")
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(first, second));
        }
        else if (type == "char")
        {
            var first = char.Parse(Console.ReadLine());
            var second = char.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(first, second));
        }
        else if (type == "string")
        {
            var first = Console.ReadLine();
            var second = Console.ReadLine();
            Console.WriteLine(GetMax(first, second));
        }
    }

    private static int GetMax(int first, int second)
    {
        if (first >= second)
        {
            return first;
        }
        return second;
    }

    private static char GetMax(char first, char second)
    {
        if (first >= second)
        {
            return first;
        }
        return second;
    }

    // Strings can't be compared with < and >, so we use CompareTo:
    // it gives a number bigger than 0 if the first string comes later in the alphabet
    private static string GetMax(string first, string second)
    {
        if (first.CompareTo(second) >= 0)
        {
            return first;
        }
        return second;
    }
}
