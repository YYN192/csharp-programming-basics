namespace C_sharp_school_introduction.Lesson04_1_ComplexConditions;

// Example: Invalid Number
// A number is valid if it is between 100 and 200 (including) or if it is 0.
// Print "invalid" if the number is NOT valid. Print nothing if it is valid.
public static class InvalidNumber
{
    public static void Run()
    {
        var number = int.Parse(Console.ReadLine());

        var isValid = (number >= 100 && number <= 200) || number == 0;

        if (!isValid)
        {
            Console.WriteLine("invalid");
        }
    }
}
