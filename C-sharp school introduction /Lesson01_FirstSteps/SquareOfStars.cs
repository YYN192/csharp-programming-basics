namespace C_sharp_school_introduction.Lesson01_FirstSteps;

// * Problem: Square of Stars
// Read a number n and print a hollow square of stars with side n.
// Example for n = 4:
// ****
// *  *
// *  *
// ****
public static class SquareOfStars
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        // Top side
        Console.WriteLine(new string('*', n));

        // Middle rows: a star, spaces, a star
        for (int row = 0; row < n - 2; row++)
        {
            Console.WriteLine("*" + new string(' ', n - 2) + "*");
        }

        // Bottom side
        Console.WriteLine(new string('*', n));
    }
}
