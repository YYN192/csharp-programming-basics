namespace C_sharp_school_introduction.Lesson07_1_ComplexLoops;

// Example: Numbers from 1 to 2^n
// Read n and print the powers of 2: 1, 2, 4, 8, ... up to 2^n.
public static class PowersOfTwo
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var number = 1;

        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(number);
            number = number * 2;
        }
    }
}
