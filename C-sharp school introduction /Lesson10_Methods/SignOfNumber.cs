namespace C_sharp_school_introduction.Lesson10_Methods;

// Example: Sign of an Integer (a method with a parameter)
// Read a whole number and print if it is positive, negative or zero.
public static class SignOfNumber
{
    public static void Run()
    {
        var number = int.Parse(Console.ReadLine());
        PrintSign(number);
    }

    private static void PrintSign(int number)
    {
        if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine($"The number {number} is negative.");
        }
        else
        {
            Console.WriteLine($"The number {number} is zero.");
        }
    }
}
