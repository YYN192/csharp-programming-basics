namespace C_sharp_school_introduction.Lesson10_Methods;

// Problem: "Hello, Name!"
// Read a name and print "Hello, <name>!" with a method PrintName.
public static class HelloName
{
    public static void Run()
    {
        var name = Console.ReadLine();
        PrintName(name);
    }

    private static void PrintName(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}
