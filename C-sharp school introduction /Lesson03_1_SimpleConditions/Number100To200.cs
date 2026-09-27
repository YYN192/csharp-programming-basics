namespace C_sharp_school_introduction.Lesson03_1_SimpleConditions;

// Problem: Number from 100 to 200
// Read a whole number and check if it is below 100, between 100 and 200, or above 200.
public static class Number100To200
{
    public static void Run()
    {
        var number = int.Parse(Console.ReadLine());

        if (number < 100)
        {
            Console.WriteLine("Less than 100");
        }
        else if (number <= 200)
        {
            Console.WriteLine("Between 100 and 200");
        }
        else
        {
            Console.WriteLine("Greater than 200");
        }
    }
}
