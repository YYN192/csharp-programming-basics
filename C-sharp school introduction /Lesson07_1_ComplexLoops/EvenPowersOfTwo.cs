namespace C_sharp_school_introduction.Lesson07_1_ComplexLoops;

// Example: Even Powers of 2
// Read n and print 2^0, 2^2, 2^4, ... up to 2^n. For n = 10: 1, 4, 16, 64, 256, 1024
public static class EvenPowersOfTwo
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var number = 1;

        for (int i = 0; i <= n; i += 2)
        {
            Console.WriteLine(number);
            number = number * 2 * 2;
        }
    }
}
