namespace C_sharp_school_introduction.Lesson05_2_LoopsExam;

// Exam problem: Histogram
// Read n numbers from 1 to 1000. Print what percent of them are:
// under 200, from 200 to 399, from 400 to 599, from 600 to 799, and 800 or more.
public static class Histogram
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var group1 = 0;
        var group2 = 0;
        var group3 = 0;
        var group4 = 0;
        var group5 = 0;

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());

            if (number < 200)
            {
                group1++;
            }
            else if (number < 400)
            {
                group2++;
            }
            else if (number < 600)
            {
                group3++;
            }
            else if (number < 800)
            {
                group4++;
            }
            else
            {
                group5++;
            }
        }

        // Multiply by 100.0 (not 100) so the division gives a number with decimals
        Console.WriteLine($"{group1 * 100.0 / n:f2}%");
        Console.WriteLine($"{group2 * 100.0 / n:f2}%");
        Console.WriteLine($"{group3 * 100.0 / n:f2}%");
        Console.WriteLine($"{group4 * 100.0 / n:f2}%");
        Console.WriteLine($"{group5 * 100.0 / n:f2}%");
    }
}
