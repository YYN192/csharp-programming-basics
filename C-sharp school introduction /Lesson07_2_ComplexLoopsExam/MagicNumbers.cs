namespace C_sharp_school_introduction.Lesson07_2_ComplexLoopsExam;

// Exam problem: Magic Numbers
// Read a "magic" number and print all 6-digit numbers whose digits multiply to the magic number.
// Example: magic number 2 -> 111112 (1 * 1 * 1 * 1 * 1 * 2 = 2), 111121, ...
// A digit 0 would make the product 0, so each digit goes from 1 to 9.
public static class MagicNumbers
{
    public static void Run()
    {
        var magicNumber = int.Parse(Console.ReadLine());

        for (int d1 = 1; d1 <= 9; d1++)
        {
            for (int d2 = 1; d2 <= 9; d2++)
            {
                for (int d3 = 1; d3 <= 9; d3++)
                {
                    for (int d4 = 1; d4 <= 9; d4++)
                    {
                        for (int d5 = 1; d5 <= 9; d5++)
                        {
                            for (int d6 = 1; d6 <= 9; d6++)
                            {
                                if (d1 * d2 * d3 * d4 * d5 * d6 == magicNumber)
                                {
                                    Console.Write($"{d1}{d2}{d3}{d4}{d5}{d6} ");
                                }
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine();
    }
}
