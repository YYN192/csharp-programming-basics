namespace C_sharp_school_introduction.Lesson07_1_ComplexLoops;

// Example: Number in the Range [1...100]
// Read a number. While it is not between 1 and 100, print "Invalid number!" and read again.
public static class NumberInRange1To100
{
    public static void Run()
    {
        var number = int.Parse(Console.ReadLine());

        while (number < 1 || number > 100)
        {
            Console.WriteLine("Invalid number!");
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"The number is: {number}");
    }
}
