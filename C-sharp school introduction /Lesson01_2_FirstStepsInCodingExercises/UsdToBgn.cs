namespace C_sharp_school_introduction.Lesson01_2_FirstStepsInCodingExercises;

// Задача 4: Конзолен конвертор USD към BGN
// Фиксиран курс: 1 USD = 1.79549 BGN.
// Явор — 28.09.2026
public static class UsdToBgn
{
    public static void Run()
    {
        var usd = double.Parse(Console.ReadLine());

        var bgn = usd * 1.79549;

        Console.WriteLine(bgn);
    }
}
