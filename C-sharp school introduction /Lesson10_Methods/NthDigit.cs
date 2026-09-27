namespace C_sharp_school_introduction.Lesson10_Methods;

// Problem: N-th Digit
// Read a number and an index and print the digit at that index, counting from the right, starting at 1.
// Example: 83746 and 2 -> 4
public static class NthDigit
{
    public static void Run()
    {
        var number = long.Parse(Console.ReadLine());
        var index = int.Parse(Console.ReadLine());

        Console.WriteLine(FindNthDigit(number, index));
    }

    private static long FindNthDigit(long number, int index)
    {
        var currentIndex = 1;
        while (number != 0)
        {
            if (currentIndex == index)
            {
                return number % 10;
            }

            number = number / 10;  // remove the last digit
            currentIndex++;
        }

        return 0;
    }
}
