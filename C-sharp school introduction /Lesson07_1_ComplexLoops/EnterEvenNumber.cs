namespace C_sharp_school_introduction.Lesson07_1_ComplexLoops;

// Example: Enter an Even Number (break in an endless loop)
// Keep reading numbers until the user enters an even number, then print it.
public static class EnterEvenNumber
{
    public static void Run()
    {
        var n = 0;

        while (true)
        {
            Console.Write("Enter even number: ");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                break;  // even number -> exit from the loop
            }

            Console.WriteLine("The number is not even.");
        }

        Console.WriteLine($"Even number entered: {n}");
    }
}
