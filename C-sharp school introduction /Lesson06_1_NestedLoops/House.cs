namespace C_sharp_school_introduction.Lesson06_1_NestedLoops;

// Problem: House
// Read n and print a house with size n x n, like this for n = 5:
// --*--
// -***-
// *****
// |***|
// |***|
public static class House
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        // Roof: starts with 1 star (odd n) or 2 stars (even n), and grows by 2 stars each row
        var stars = 1;
        if (n % 2 == 0)
        {
            stars = 2;
        }

        var roofRows = (n + 1) / 2;
        for (int row = 0; row < roofRows; row++)
        {
            var dashes = new string('-', (n - stars) / 2);
            Console.WriteLine(dashes + new string('*', stars) + dashes);
            stars = stars + 2;
        }

        // Base: the rest of the rows
        var baseRows = n - roofRows;
        for (int row = 0; row < baseRows; row++)
        {
            Console.WriteLine("|" + new string('*', n - 2) + "|");
        }
    }
}
