namespace C_sharp_school_introduction.Lesson01_2_FirstStepsInCodingExercises;

// Задача 7: Задължителна литература
// часове на ден = (страници / страници за час) / брой дни
// Явор — 28.09.2026
public static class MandatoryLiterature
{
    public static void Run()
    {
        var pages = int.Parse(Console.ReadLine());
        var pagesPerHour = double.Parse(Console.ReadLine());
        var days = int.Parse(Console.ReadLine());

        Console.WriteLine(pages / pagesPerHour / days);
    }
}
