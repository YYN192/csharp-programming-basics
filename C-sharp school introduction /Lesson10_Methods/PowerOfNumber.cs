namespace C_sharp_school_introduction.Lesson10_Methods;

// Example: Power of a Number
// Read a number and a power and print the number raised to that power. 2 and 8 -> 256
public static class PowerOfNumber
{
    public static void Run()
    {
        var number = double.Parse(Console.ReadLine());
        var power = int.Parse(Console.ReadLine());

        var result = RaiseToPower(number, power);
        Console.WriteLine(result);
    }

    private static double RaiseToPower(double number, int power)
    {
        var result = 1.0;
        for (int i = 0; i < power; i++)
        {
            result = result * number;
        }
        return result;
    }
}
