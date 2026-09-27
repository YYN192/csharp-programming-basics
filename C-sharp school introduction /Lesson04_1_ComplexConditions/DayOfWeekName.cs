namespace C_sharp_school_introduction.Lesson04_1_ComplexConditions;

// Example: Day of the Week (switch-case)
// Read a number from 1 to 7 and print the day of the week, or "Error!" for any other number.
public static class DayOfWeekName
{
    public static void Run()
    {
        var day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Error!");
                break;
        }
    }
}
