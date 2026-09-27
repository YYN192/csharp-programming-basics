namespace C_sharp_school_introduction.Lesson07_1_ComplexLoops;

// Example: Sequence 2k + 1 (while loop)
// Read n and print all numbers up to n from the sequence 1, 3, 7, 15, 31, ...
// Every next number = previous number * 2 + 1
public static class Sequence2kPlus1
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var number = 1;

        while (number <= n)
        {
            Console.WriteLine(number);
            number = number * 2 + 1;
        }
    }
}
