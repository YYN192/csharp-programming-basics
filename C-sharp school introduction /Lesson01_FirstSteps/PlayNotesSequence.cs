namespace C_sharp_school_introduction.Lesson01_FirstSteps;

// Example: a program that plays notes from 200 Hz up to 4000 Hz, going up by 200 Hz.
// Note: Console.Beep with a sound height only works on Windows.
public static class PlayNotesSequence
{
    public static void Run()
    {
        for (int i = 200; i <= 4000; i += 200)
        {
            if (OperatingSystem.IsWindows())
            {
                Console.Beep(i, 100);
            }
            else
            {
                Console.WriteLine($"Beep: {i} Hz");
            }
        }
    }
}
