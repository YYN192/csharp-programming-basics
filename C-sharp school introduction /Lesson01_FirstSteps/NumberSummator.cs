namespace C_sharp_school_introduction.Lesson01_FirstSteps;

// Lab: "Summator" (sum of two numbers)
// In the book this is a Windows Forms / web app with two text boxes and a [Calculate] button.
// Windows Forms runs only on Windows, so here is the same logic as a console app:
// read two numbers and print their sum, or "error" if the input is not a number.
public static class NumberSummator
{
    public static void Run()
    {
        try
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var sum = num1 + num2;
            Console.WriteLine(sum);
        }
        catch
        {
            Console.WriteLine("error");
        }
    }
}
