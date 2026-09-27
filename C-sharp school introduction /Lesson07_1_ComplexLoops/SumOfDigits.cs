namespace C_sharp_school_introduction.Lesson07_1_ComplexLoops;

// Example: Sum of Digits (do-while loop)
// Read a positive number and print the sum of its digits. For example 5634 -> 5 + 6 + 3 + 4 = 18.
// Remember: n % 10 gives the last digit, n / 10 removes the last digit.
public static class SumOfDigits
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var sum = 0;

        do
        {
            sum = sum + n % 10;
            n = n / 10;
        } while (n > 0);

        Console.WriteLine(sum);
    }
}
