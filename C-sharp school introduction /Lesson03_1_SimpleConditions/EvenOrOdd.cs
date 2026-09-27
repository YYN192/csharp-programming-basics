namespace C_sharp_school_introduction.Lesson03_1_SimpleConditions;

// Problem: Even or Odd
// Read a whole number and print "even" or "odd".
// A number is even when dividing it by 2 leaves no remainder (the % operator gives the remainder).
public static class EvenOrOdd
{
    public static void Run()
    {
        var number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }
}
