namespace C_sharp_school_introduction.Lesson01_FirstSteps;

// Example: a program that plays the musical note "A" (432 Hz) for half a second.
// Note: Console.Beep with a sound height only works on Windows.
public static class PlayNoteA
{
    public static void Run()
    {
        if (OperatingSystem.IsWindows())
        {
            Console.Beep(432, 500);
        }
        else
        {
            Console.WriteLine("Console.Beep(432, 500) plays a sound only on Windows.");
        }
    }
}
