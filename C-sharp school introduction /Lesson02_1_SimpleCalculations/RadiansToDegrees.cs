namespace C_sharp_school_introduction.Lesson02_1_SimpleCalculations;

// Problem: Converter from Radians to Degrees
// Read an angle in radians and convert it to degrees, rounded to a whole number.
// Formula: degrees = radians * 180 / PI
public static class RadiansToDegrees
{
    public static void Run()
    {
        var radians = double.Parse(Console.ReadLine());
        var degrees = radians * 180 / Math.PI;
        Console.WriteLine(Math.Round(degrees));
    }
}
