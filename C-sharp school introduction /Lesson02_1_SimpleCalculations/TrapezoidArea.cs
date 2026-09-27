namespace C_sharp_school_introduction.Lesson02_1_SimpleCalculations;

// Problem: Trapezoid Area
// Read b1, b2 and h and print the area of the trapezoid: (b1 + b2) * h / 2
public static class TrapezoidArea
{
    public static void Run()
    {
        var b1 = double.Parse(Console.ReadLine());
        var b2 = double.Parse(Console.ReadLine());
        var h = double.Parse(Console.ReadLine());

        var area = (b1 + b2) * h / 2;

        Console.WriteLine("Trapezoid area = " + area);
    }
}
