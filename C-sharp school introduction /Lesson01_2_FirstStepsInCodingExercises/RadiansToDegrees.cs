namespace C_sharp_school_introduction.Lesson01_2_FirstStepsInCodingExercises;

// Задача 5: Конзолен конвертор от радиани в градуси
// Формула: градуси = радиани * 180 / PI, закръглени до цяло число.
// Явор — 28.09.2026
public static class RadiansToDegrees
{
    public static void Run()
    {
        var radians = double.Parse(Console.ReadLine());

        var degrees = radians * 180 / Math.PI;

        Console.WriteLine(Math.Round(degrees));
    }
}
