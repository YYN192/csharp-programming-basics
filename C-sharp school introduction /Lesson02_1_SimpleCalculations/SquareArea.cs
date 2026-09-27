namespace C_sharp_school_introduction.Lesson02_1_SimpleCalculations;

// Problem: Square Area
// Read a whole number a and print the area of a square with side a.
public static class SquareArea
{
    public static void Run()
    {
        Console.Write("a = ");
        var a = int.Parse(Console.ReadLine());
        var area = a * a;
        Console.Write("Square area = ");
        Console.WriteLine(area);
    }
}
