namespace C_sharp_school_introduction.Lesson05_1_Loops;

// Problem: Element Equal to the Sum of the Rest
// Read n numbers. Is there a number that equals the sum of all the others?
// Yes -> "Yes" and "Sum = <that number>"
// No  -> "No" and "Diff = <difference between the biggest number and the sum of the others>"
// Idea: only the biggest number can be equal to the sum of the rest.
public static class HalfSumElement
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var sum = 0;
        var max = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());
            sum = sum + number;
            if (number > max)
            {
                max = number;
            }
        }

        var sumOfTheRest = sum - max;

        if (max == sumOfTheRest)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {max}");
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {Math.Abs(max - sumOfTheRest)}");
        }
    }
}
