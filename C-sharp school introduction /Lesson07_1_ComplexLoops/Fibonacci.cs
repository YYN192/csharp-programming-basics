namespace C_sharp_school_introduction.Lesson07_1_ComplexLoops;

// Problem: Fibonacci Numbers
// The Fibonacci numbers are 1, 1, 2, 3, 5, 8, 13, 21, ... (each number is the sum of the two before it).
// Read n and print the n-th Fibonacci number (F0 = 1, F1 = 1).
public static class Fibonacci
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var f0 = 1;
        var f1 = 1;

        for (int i = 0; i < n - 1; i++)
        {
            var fNext = f0 + f1;
            f0 = f1;
            f1 = fNext;
        }

        Console.WriteLine(f1);
    }
}
