namespace C_sharp_school_introduction.Lesson08_1_ExamPreparation;

// Exam problem: Increasing Elements
// Read n numbers and print the length of the longest run of numbers that go up one after another.
public static class IncreasingElements
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var previous = int.MinValue;
        var currentLength = 0;
        var longestLength = 0;

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());

            if (number > previous)
            {
                currentLength++;
            }
            else
            {
                currentLength = 1;  // a new run starts with this number
            }

            if (currentLength > longestLength)
            {
                longestLength = currentLength;
            }

            previous = number;
        }

        Console.WriteLine(longestLength);
    }
}
