namespace C_sharp_school_introduction.Lesson07_1_ComplexLoops;

// Example: Greatest Common Divisor (GCD)
// Read two whole numbers a and b and print their GCD with the Euclidean algorithm:
// while b is not 0: remember b, set b to the remainder a % b, set a to the old b.
public static class GreatestCommonDivisor
{
    public static void Run()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());

        while (b != 0)
        {
            var oldB = b;
            b = a % b;
            a = oldB;
        }

        Console.WriteLine(a);
    }
}
