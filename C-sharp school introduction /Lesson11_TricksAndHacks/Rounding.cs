namespace C_sharp_school_introduction.Lesson11_TricksAndHacks;

// Trick: Rounding Numbers
//  - Math.Round(number, 2): rounds to 2 digits after the decimal point
//  - Math.Floor(number):    always rounds DOWN to a whole number (5.99 -> 5)
//  - Math.Ceiling(number):  always rounds UP to a whole number (5.11 -> 6)
//  - {0:f2} or {number:f2}: prints the number with exactly 2 digits after the decimal point
public static class Rounding
{
    public static void Run()
    {
        Console.WriteLine(Math.Round(5.432432, 2));  // 5.43
        Console.WriteLine(Math.Round(5.439, 2));     // 5.44

        Console.WriteLine(Math.Floor(5.99));         // 5
        Console.WriteLine(Math.Ceiling(5.11));       // 6

        var number = 5.432424;
        Console.WriteLine("{0:f2}", number);         // 5.43
        Console.WriteLine($"{number:f3}");           // 5.432
    }
}
