namespace C_sharp_school_introduction.Lesson07_1_ComplexLoops;

// Example: Factorial (do-while loop)
// Read n and print n! = 1 * 2 * 3 * ... * n. For example 5! = 120.
// We use long, because factorials grow very fast and don't fit in int.
public static class Factorial
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        long factorial = 1;

        do
        {
            factorial = factorial * n;
            n--;
        } while (n > 1);

        Console.WriteLine(factorial);
    }
}
