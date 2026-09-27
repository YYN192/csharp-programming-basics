namespace C_sharp_school_introduction.Lesson02_1_SimpleCalculations;

// Problem: Circle Area and Perimeter
// Read a radius r and print the area and the perimeter of the circle.
// Area = PI * r * r
// Perimeter = 2 * PI * r
public static class CircleAreaAndPerimeter
{
    public static void Run()
    {
        var r = double.Parse(Console.ReadLine());

        var area = Math.PI * r * r;
        var perimeter = 2 * Math.PI * r;

        Console.WriteLine("Area = " + area);
        Console.WriteLine("Perimeter = " + perimeter);
    }
}
