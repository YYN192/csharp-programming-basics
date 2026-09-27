namespace C_sharp_school_introduction.Lesson08_1_ExamPreparation;

// Exam problem: Sums of 3 Numbers
// Read 3 numbers. Check if the sum of two of them equals the third one.
// Print "a + b = c" (with a <= b) or "No".
public static class SumsOf3Numbers
{
    public static void Run()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());

        if (a + b == c)
        {
            Console.WriteLine($"{Math.Min(a, b)} + {Math.Max(a, b)} = {c}");
        }
        else if (a + c == b)
        {
            Console.WriteLine($"{Math.Min(a, c)} + {Math.Max(a, c)} = {b}");
        }
        else if (b + c == a)
        {
            Console.WriteLine($"{Math.Min(b, c)} + {Math.Max(b, c)} = {a}");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
