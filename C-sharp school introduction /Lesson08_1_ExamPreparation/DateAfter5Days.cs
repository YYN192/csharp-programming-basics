namespace C_sharp_school_introduction.Lesson08_1_ExamPreparation;

// Exam problem: Date After 5 Days
// Read a day and a month and print the date 5 days later as day.month (the month always has 2 digits).
// April, June, September and November have 30 days, February has 28 days, the rest have 31 days.
public static class DateAfter5Days
{
    public static void Run()
    {
        var day = int.Parse(Console.ReadLine());
        var month = int.Parse(Console.ReadLine());

        var daysInMonth = 31;
        if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            daysInMonth = 30;
        }
        else if (month == 2)
        {
            daysInMonth = 28;
        }

        day = day + 5;

        // Did we go into the next month?
        if (day > daysInMonth)
        {
            day = day - daysInMonth;
            month++;

            // After December comes January
            if (month > 12)
            {
                month = 1;
            }
        }

        Console.WriteLine($"{day}.{month:D2}");
    }
}
