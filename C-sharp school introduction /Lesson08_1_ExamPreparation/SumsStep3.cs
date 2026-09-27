namespace C_sharp_school_introduction.Lesson08_1_ExamPreparation;

// Exam problem: Sums with Step 3
// Read n numbers a1, a2, ..., an and print:
// sum1 = a1 + a4 + a7 + ...
// sum2 = a2 + a5 + a8 + ...
// sum3 = a3 + a6 + a9 + ...
public static class SumsStep3
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var sum1 = 0;
        var sum2 = 0;
        var sum3 = 0;

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());

            if (i % 3 == 0)
            {
                sum1 = sum1 + number;
            }
            else if (i % 3 == 1)
            {
                sum2 = sum2 + number;
            }
            else
            {
                sum3 = sum3 + number;
            }
        }

        Console.WriteLine($"sum1 = {sum1}");
        Console.WriteLine($"sum2 = {sum2}");
        Console.WriteLine($"sum3 = {sum3}");
    }
}
