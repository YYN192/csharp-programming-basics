namespace C_sharp_school_introduction.Lesson02_1_SimpleCalculations;

// Problem: Inches to Centimeters
// Read a number (it can have a decimal part) and convert it from inches to centimeters.
// 1 inch = 2.54 centimeters
public static class InchesToCentimeters
{
    public static void Run()
    {
        Console.Write("Inches = ");
        var inches = double.Parse(Console.ReadLine());
        var centimeters = inches * 2.54;
        Console.Write("Centimeters = ");
        Console.WriteLine(centimeters);
    }
}
