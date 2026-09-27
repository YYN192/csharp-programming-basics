namespace C_sharp_school_introduction.Lesson05_2_LoopsExam;

// Exam problem: Hospital
// The hospital starts with 7 doctors. Each doctor treats 1 patient per day.
// Every third day, if there are more untreated patients than treated ones, a new doctor is hired
// (before the patients of that day arrive).
// Read the number of days and the patients for each day. Print the treated and untreated patients.
public static class Hospital
{
    public static void Run()
    {
        var days = int.Parse(Console.ReadLine());
        var doctors = 7;
        var treated = 0;
        var untreated = 0;

        for (int day = 1; day <= days; day++)
        {
            if (day % 3 == 0 && untreated > treated)
            {
                doctors++;
            }

            var patients = int.Parse(Console.ReadLine());

            if (patients <= doctors)
            {
                treated = treated + patients;
            }
            else
            {
                treated = treated + doctors;
                untreated = untreated + (patients - doctors);
            }
        }

        Console.WriteLine($"Treated patients: {treated}.");
        Console.WriteLine($"Untreated patients: {untreated}.");
    }
}
