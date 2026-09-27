namespace C_sharp_school_introduction.Lesson08_2_ExamPreparation;

// Exam problem: Letter Combinations
// Read a start letter, an end letter and a letter to skip.
// Print all 3-letter combinations of the letters from start to end, except the ones
// that contain the skipped letter. At the end print how many combinations were printed.
public static class LetterCombinations
{
    public static void Run()
    {
        var start = char.Parse(Console.ReadLine());
        var end = char.Parse(Console.ReadLine());
        var skip = char.Parse(Console.ReadLine());
        var count = 0;

        for (char first = start; first <= end; first++)
        {
            for (char second = start; second <= end; second++)
            {
                for (char third = start; third <= end; third++)
                {
                    if (first != skip && second != skip && third != skip)
                    {
                        Console.Write($"{first}{second}{third} ");
                        count++;
                    }
                }
            }
        }

        Console.WriteLine(count);
    }
}
