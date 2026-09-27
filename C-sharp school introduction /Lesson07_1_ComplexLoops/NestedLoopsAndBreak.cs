namespace C_sharp_school_introduction.Lesson07_1_ComplexLoops;

// Example: Nested Loops and break
// Print pairs "i j", where i goes from 1 to 3 and j goes from 3 down to 1.
// Stop everything when i + j == 2.
// "break" stops only the inner loop, so we use a bool variable to stop the outer loop too.
public static class NestedLoopsAndBreak
{
    public static void Run()
    {
        var hasToEnd = false;

        for (int i = 1; i <= 3; i++)
        {
            if (hasToEnd)
            {
                break;
            }

            for (int j = 3; j >= 1; j--)
            {
                if (i + j == 2)
                {
                    hasToEnd = true;
                    break;
                }

                Console.WriteLine(i + " " + j);
            }
        }
    }
}
