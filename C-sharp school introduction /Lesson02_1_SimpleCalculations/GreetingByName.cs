namespace C_sharp_school_introduction.Lesson02_1_SimpleCalculations;

// Problem: Greeting by Name
// Read a name and print "Hello, <name>!"
public static class GreetingByName
{
    public static void Run()
    {
        var name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }
}
