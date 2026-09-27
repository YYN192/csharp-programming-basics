namespace C_sharp_school_introduction.Lesson03_1_SimpleConditions;

// Problem: Equal 3 Numbers
// Read 3 numbers and print "yes" if they are all the same, otherwise "no".
public static class EqualNumbers
{
    public static void Run()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());

        if (a == b && b == c)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
