namespace C_sharp_school_introduction.Lesson01_FirstSteps;

// Example: read an amount in leva (a whole number) and convert it to euro.
public static class LevaToEuro
{
    public static void Run()
    {
        var leva = int.Parse(Console.ReadLine());
        var euro = leva / 1.95583;
        Console.WriteLine(euro);
    }
}
