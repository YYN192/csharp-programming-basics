namespace C_sharp_school_introduction.Lesson08_1_ExamPreparation;

// Exam problem: Increasing 4 Numbers
// Read a and b and print all groups of 4 numbers n1, n2, n3, n4 where a <= n1 < n2 < n3 < n4 <= b.
// If there are none, print "No".
public static class Increasing4Numbers
{
    public static void Run()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var found = false;

        // Each next number starts from the previous number + 1, so they always go up
        for (int n1 = a; n1 <= b; n1++)
        {
            for (int n2 = n1 + 1; n2 <= b; n2++)
            {
                for (int n3 = n2 + 1; n3 <= b; n3++)
                {
                    for (int n4 = n3 + 1; n4 <= b; n4++)
                    {
                        Console.WriteLine($"{n1} {n2} {n3} {n4}");
                        found = true;
                    }
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No");
        }
    }
}
