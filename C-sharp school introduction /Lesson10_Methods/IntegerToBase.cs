namespace C_sharp_school_introduction.Lesson10_Methods;

// Problem: Integer to Base
// Read a number and a base (from 2 to 10) and print the number written in that base.
// Example: 3 in base 2 is 11
// How: take the remainder of number / base and put it at the front of the result,
// then divide the number by the base. Repeat until the number becomes 0.
public static class IntegerToBase
{
    public static void Run()
    {
        var number = int.Parse(Console.ReadLine());
        var toBase = int.Parse(Console.ReadLine());

        Console.WriteLine(ConvertToBase(number, toBase));
    }

    private static string ConvertToBase(int number, int toBase)
    {
        var result = "";
        while (number != 0)
        {
            var remainder = number % toBase;
            result = remainder + result;
            number = number / toBase;
        }
        return result;
    }
}
