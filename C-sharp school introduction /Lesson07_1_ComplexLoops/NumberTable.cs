namespace C_sharp_school_introduction.Lesson07_1_ComplexLoops;

// Problem: Number Table
// Print the numbers 1...n in a table like this for n = 4:
// 1 2 3 4
// 2 3 4 3
// 3 4 3 2
// 4 3 2 1
// The number is row + col + 1. If it gets bigger than n, it "bounces back": 2 * n - number.
public static class NumberTable
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                var number = row + col + 1;
                if (number > n)
                {
                    number = 2 * n - number;
                }

                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
