namespace C_sharp_school_introduction.Lesson06_2_NestedLoopsExam;

// Exam problem: Butterfly
// Read n and draw a butterfly. Its wings are n - 2 wide. Example for n = 5:
// ***\ /***
// ---\ /---
// ***\ /***
//     @
// ***/ \***
// ---/ \---
// ***/ \***
public static class Butterfly
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var stars = new string('*', n - 2);
        var dashes = new string('-', n - 2);

        // Top wings: the rows change between stars and dashes
        for (int row = 1; row <= n - 2; row++)
        {
            if (row % 2 == 1)
            {
                Console.WriteLine(stars + "\\ /" + stars);
            }
            else
            {
                Console.WriteLine(dashes + "\\ /" + dashes);
            }
        }

        // Body
        Console.WriteLine(new string(' ', n - 1) + "@");

        // Bottom wings
        for (int row = 1; row <= n - 2; row++)
        {
            if (row % 2 == 1)
            {
                Console.WriteLine(stars + "/ \\" + stars);
            }
            else
            {
                Console.WriteLine(dashes + "/ \\" + dashes);
            }
        }
    }
}
