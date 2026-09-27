namespace C_sharp_school_introduction.Lesson02_1_SimpleCalculations;

// ** Problem: 1000 Days on the Earth
// Read a birth date in the format dd-MM-yyyy and print the date when the person
// becomes 1000 days old, in the same format.
// DateTime does all the hard work with months and leap years for us.
public static class ThousandDaysOnEarth
{
    public static void Run()
    {
        var birthDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

        // The day of birth is day 1, so day 1000 comes 999 days later.
        var after1000Days = birthDate.AddDays(999);

        Console.WriteLine(after1000Days.ToString("dd-MM-yyyy"));
    }
}
