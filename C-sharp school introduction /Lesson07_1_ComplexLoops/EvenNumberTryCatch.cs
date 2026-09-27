namespace C_sharp_school_introduction.Lesson07_1_ComplexLoops;

// Example: Dealing with Invalid Numbers (try-catch)
// Keep reading until the user enters an even number.
// If the text is not a number at all, int.Parse throws an error and we catch it.
public static class EvenNumberTryCatch
{
    public static void Run()
    {
        while (true)
        {
            try
            {
                Console.Write("Enter even number: ");
                var n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    Console.WriteLine($"Even number entered: {n}");
                    break;
                }

                Console.WriteLine("The number is not even.");
            }
            catch
            {
                Console.WriteLine("Invalid number.");
            }
        }
    }
}
