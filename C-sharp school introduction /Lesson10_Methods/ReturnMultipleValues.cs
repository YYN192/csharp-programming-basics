namespace C_sharp_school_introduction.Lesson10_Methods;

// Example: A Method that Returns Several Values (ValueTuple)
// Divide returns two values at once: the result of the division and the remainder.
public static class ReturnMultipleValues
{
    public static void Run()
    {
        var personInfo = (name: "Steeve", age: 27, "Bulgaria");
        Console.WriteLine($"{personInfo.name} is {personInfo.age} years old and lives in {personInfo.Item3}.");

        var division = Divide(17, 5);
        Console.WriteLine($"17 / 5 = {division.result}, remainder {division.remainder}");
    }

    private static (int result, int remainder) Divide(int x, int y)
    {
        var result = x / y;
        var remainder = x % y;
        return (result, remainder);
    }
}
