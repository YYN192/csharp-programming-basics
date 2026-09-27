namespace C_sharp_school_introduction.Lesson05_2_LoopsExam;

// Exam problem: Division without Remainder
// Read n numbers. Print what percent of them can be divided by 2, by 3 and by 4 without a remainder.
public static class DivisionWithoutRemainder
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var divisibleBy2 = 0;
        var divisibleBy3 = 0;
        var divisibleBy4 = 0;

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                divisibleBy2++;
            }
            if (number % 3 == 0)
            {
                divisibleBy3++;
            }
            if (number % 4 == 0)
            {
                divisibleBy4++;
            }
        }

        Console.WriteLine($"{divisibleBy2 * 100.0 / n:f2}%");
        Console.WriteLine($"{divisibleBy3 * 100.0 / n:f2}%");
        Console.WriteLine($"{divisibleBy4 * 100.0 / n:f2}%");
    }
}
