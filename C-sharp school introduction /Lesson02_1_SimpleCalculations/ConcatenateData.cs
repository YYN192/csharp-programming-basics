namespace C_sharp_school_introduction.Lesson02_1_SimpleCalculations;

// Problem: Concatenating Text and Numbers
// Read first name, last name, age and town, then print:
// "You are <firstName> <lastName>, a <age>-years old person from <town>."
public static class ConcatenateData
{
    public static void Run()
    {
        var firstName = Console.ReadLine();
        var lastName = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        var town = Console.ReadLine();

        Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
    }
}
