namespace C_sharp_school_introduction.Lesson01_FirstSteps;

// Problem: Rectangle Area
// Read two whole numbers a and b and print the area of a rectangle with sides a and b.
public static class RectangleArea
{
    public static void Run()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        Console.WriteLine(a * b);
    }
}
