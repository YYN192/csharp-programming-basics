namespace C_sharp_school_introduction.Lesson03_1_SimpleConditions;

// Problem: Finding the Greater Number
// Read two whole numbers and print the greater one.
public static class GreaterNumber
{
    public static void Run()
    {
        var first = int.Parse(Console.ReadLine());
        var second = int.Parse(Console.ReadLine());

        if (first > second)
        {
            Console.WriteLine(first);
        }
        else
        {
            Console.WriteLine(second);
        }
    }
}
