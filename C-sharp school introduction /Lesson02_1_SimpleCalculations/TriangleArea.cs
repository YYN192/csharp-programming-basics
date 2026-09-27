namespace C_sharp_school_introduction.Lesson02_1_SimpleCalculations;

// Problem: Triangle Area
// Read a side a and a height h and print the area of the triangle: a * h / 2
// Round the result to 2 digits after the decimal point.
public static class TriangleArea
{
    public static void Run()
    {
        var a = double.Parse(Console.ReadLine());
        var h = double.Parse(Console.ReadLine());

        var area = a * h / 2;

        Console.WriteLine("Triangle area = " + Math.Round(area, 2));
    }
}
