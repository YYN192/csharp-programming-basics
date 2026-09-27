namespace C_sharp_school_introduction.Lesson05_1_Loops;

// Example: Numbers up to 1000 Ending in 7
// Print all numbers from 1 to 1000 that end with the digit 7.
public static class NumbersEndingIn7
{
    public static void Run()
    {
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 10 == 7)
            {
                Console.WriteLine(i);
            }
        }
    }
}
