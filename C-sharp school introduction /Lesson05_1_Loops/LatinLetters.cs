namespace C_sharp_school_introduction.Lesson05_1_Loops;

// Example: All Latin Letters
// Print the letters from 'a' to 'z'. A for loop can walk through letters too!
public static class LatinLetters
{
    public static void Run()
    {
        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            Console.WriteLine(letter);
        }
    }
}
