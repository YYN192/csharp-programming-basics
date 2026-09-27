namespace C_sharp_school_introduction.Lesson10_Methods;

// Problem: Min Method
// Read three numbers and print the smallest one, using a method GetMin(a, b).
public static class MinMethod
{
    public static void Run()
    {
        var num1 = int.Parse(Console.ReadLine());
        var num2 = int.Parse(Console.ReadLine());
        var num3 = int.Parse(Console.ReadLine());

        // The min of three = the min of (the min of the first two) and the third
        var min = GetMin(GetMin(num1, num2), num3);
        Console.WriteLine(min);
    }

    private static int GetMin(int a, int b)
    {
        if (a < b)
        {
            return a;
        }
        return b;
    }
}
