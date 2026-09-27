namespace C_sharp_school_introduction.Lesson02_1_SimpleCalculations;

// Lab: Converter from BGN to EUR
// In the book this is a Windows Forms app. Here is the same logic as a console app:
// read an amount in leva and show how much it is in euro. 1 EUR = 1.95583 BGN
public static class BgnToEurConverter
{
    public static void Run()
    {
        var amountBgn = double.Parse(Console.ReadLine());
        var amountEur = amountBgn / 1.95583;
        Console.WriteLine($"{amountBgn} BGN = {Math.Round(amountEur, 2)} EUR");
    }
}
