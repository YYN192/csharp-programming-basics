namespace C_sharp_school_introduction.Lesson07_2_ComplexLoopsExam;

// Exam problem: Stop Number
// Read N, M and a "stop" number S. Print (from M down to N) the numbers that can be divided by 2 and by 3.
// If one of them equals S, don't print it and stop.
public static class StopNumber
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var m = int.Parse(Console.ReadLine());
        var stop = int.Parse(Console.ReadLine());

        for (int i = m; i >= n; i--)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                if (i == stop)
                {
                    break;
                }

                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }
}
