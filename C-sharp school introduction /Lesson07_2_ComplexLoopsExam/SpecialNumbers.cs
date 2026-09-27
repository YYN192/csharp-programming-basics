namespace C_sharp_school_introduction.Lesson07_2_ComplexLoopsExam;

// Exam problem: Special Numbers
// Read N and print all numbers from 1111 to 9999 that are "special":
// N can be divided by each of their digits without a remainder.
// A digit 0 is not allowed (we can't divide by 0), so each digit goes from 1 to 9.
public static class SpecialNumbers
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        for (int d1 = 1; d1 <= 9; d1++)
        {
            for (int d2 = 1; d2 <= 9; d2++)
            {
                for (int d3 = 1; d3 <= 9; d3++)
                {
                    for (int d4 = 1; d4 <= 9; d4++)
                    {
                        if (n % d1 == 0 && n % d2 == 0 && n % d3 == 0 && n % d4 == 0)
                        {
                            Console.Write($"{d1}{d2}{d3}{d4} ");
                        }
                    }
                }
            }
        }

        Console.WriteLine();
    }
}
