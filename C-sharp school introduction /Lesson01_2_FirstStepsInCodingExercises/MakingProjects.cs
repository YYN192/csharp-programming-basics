namespace C_sharp_school_introduction.Lesson01_2_FirstStepsInCodingExercises;

// Задача 1: Изготвяне на проекти
// Един проект отнема 3 часа. Четем име на архитект и брой проекти.
// Явор — 28.09.2026
public static class MakingProjects
{
    public static void Run()
    {
        var architect = Console.ReadLine();
        var projects = int.Parse(Console.ReadLine());

        var hours = projects * 3;

        Console.WriteLine($"The architect {architect} will need {hours} hours to complete {projects} project/s.");
    }
}
