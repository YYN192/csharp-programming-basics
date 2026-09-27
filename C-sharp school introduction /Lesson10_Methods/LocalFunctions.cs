namespace C_sharp_school_introduction.Lesson10_Methods;

// Example: Nested Methods (Local Functions)
// A method can be written inside another method. It can be used only there.
// A local function can also use the variables of the method around it.
public static class LocalFunctions
{
    public static void Run()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());

        Console.WriteLine($"{a} + {b} = {Sum()}");
        Console.WriteLine($"{a} * {b} = {Multiply(a, b)}");

        // Uses a and b from Run() directly
        double Sum()
        {
            return a + b;
        }

        double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}
