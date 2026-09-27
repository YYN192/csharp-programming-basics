namespace C_sharp_school_introduction.Lesson06_1_NestedLoops;

// Problem: Christmas Tree
// Read n and print a Christmas tree with height n + 1, like this for n = 3:
//     |
//   * | *
//  ** | **
// *** | ***
public static class ChristmasTree
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        for (int row = 0; row <= n; row++)
        {
            var spaces = new string(' ', n - row);
            var stars = new string('*', row);
            Console.WriteLine(spaces + stars + " | " + stars);
        }
    }
}
