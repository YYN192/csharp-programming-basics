namespace C_sharp_school_introduction.Lesson10_Methods;

// Example: Returning a Result from a Method
// A method can give back (return) a value instead of printing it.
//  - ReadFullName reads two names and returns them joined together
//  - CompareNumbers returns -1, 0 or 1 and uses "return" in 3 places
public static class ReturnValues
{
    public static void Run()
    {
        var fullName = ReadFullName();
        Console.WriteLine($"Full name: {fullName}");

        // 1) keep the result in a variable
        var result = CompareNumbers(5, 3);
        Console.WriteLine(result);

        // 2) use the result in an expression
        Console.WriteLine(CompareNumbers(1, 2) * 10);

        // 3) give the result to another method
        Console.WriteLine(Math.Abs(CompareNumbers(4, 4)));
    }

    private static string ReadFullName()
    {
        var firstName = Console.ReadLine();
        var lastName = Console.ReadLine();
        return firstName + " " + lastName;
    }

    private static int CompareNumbers(int first, int second)
    {
        if (first < second)
        {
            return -1;
        }

        if (first == second)
        {
            return 0;
        }

        return 1;
    }
}
