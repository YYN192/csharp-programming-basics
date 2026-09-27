namespace C_sharp_school_introduction.Lesson02_1_SimpleCalculations;

// Problem: Converter from °C to °F
// Read degrees Celsius and convert them to degrees Fahrenheit, rounded to 2 digits.
// Formula: F = C * 9 / 5 + 32
public static class CelsiusToFahrenheit
{
    public static void Run()
    {
        var celsius = double.Parse(Console.ReadLine());
        var fahrenheit = celsius * 9 / 5 + 32;
        Console.WriteLine(Math.Round(fahrenheit, 2));
    }
}
