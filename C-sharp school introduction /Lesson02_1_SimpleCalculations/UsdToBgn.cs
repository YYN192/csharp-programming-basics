namespace C_sharp_school_introduction.Lesson02_1_SimpleCalculations;

// Problem: Converter USD to BGN
// Read an amount in US dollars and convert it to Bulgarian leva. 1 USD = 1.79549 BGN
// Round the result to 2 digits after the decimal point.
public static class UsdToBgn
{
    public static void Run()
    {
        var usd = double.Parse(Console.ReadLine());
        var bgn = usd * 1.79549;
        Console.WriteLine(Math.Round(bgn, 2) + " BGN");
    }
}
