namespace C_sharp_school_introduction.Lesson03_1_SimpleConditions;

// Problem: Equal Words
// Read two words and print "yes" if they are the same (ignoring big and small letters), otherwise "no".
public static class EqualWords
{
    public static void Run()
    {
        var first = Console.ReadLine().ToLower();
        var second = Console.ReadLine().ToLower();

        if (first == second)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
