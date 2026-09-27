namespace C_sharp_school_introduction.Lesson04_2_ComplexConditionsExam;

// Exam problem: On Time for the Exam
// Read the exam time (hour, minute) and the arrival time (hour, minute).
// Print "Late", "On time" (up to 30 minutes early) or "Early" (more than 30 minutes early),
// and, if the difference is at least 1 minute, how much before or after the start.
public static class OnTimeForExam
{
    public static void Run()
    {
        var examHour = int.Parse(Console.ReadLine());
        var examMinute = int.Parse(Console.ReadLine());
        var arrivalHour = int.Parse(Console.ReadLine());
        var arrivalMinute = int.Parse(Console.ReadLine());

        // Turn both times into minutes after midnight, so they are easy to compare
        var examTime = examHour * 60 + examMinute;
        var arrivalTime = arrivalHour * 60 + arrivalMinute;
        var difference = arrivalTime - examTime;  // positive = late, negative = early

        if (difference > 0)
        {
            Console.WriteLine("Late");
        }
        else if (difference >= -30)
        {
            Console.WriteLine("On time");
        }
        else
        {
            Console.WriteLine("Early");
        }

        if (difference != 0)
        {
            var minutesApart = Math.Abs(difference);
            var beforeOrAfter = "after";
            if (difference < 0)
            {
                beforeOrAfter = "before";
            }

            if (minutesApart < 60)
            {
                Console.WriteLine($"{minutesApart} minutes {beforeOrAfter} the start");
            }
            else
            {
                var hours = minutesApart / 60;
                var minutes = minutesApart % 60;
                Console.WriteLine($"{hours}:{minutes:D2} hours {beforeOrAfter} the start");
            }
        }
    }
}
