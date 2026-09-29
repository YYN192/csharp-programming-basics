namespace C_sharp_school_introduction.Lesson01_2_FirstStepsInCodingExercises;

// Задача 3: Озеленяване на дворове
// Цената е 7.61 лв. за кв. м с ДДС, а фирмата дава 18% отстъпка.
// Явор — 28.09.2026
public static class LandscapingYards
{
    public static void Run()
    {
        var squareMeters = double.Parse(Console.ReadLine());

        var price = squareMeters * 7.61;
        var discount = price * 0.18;

        Console.WriteLine($"The final price is: {price - discount:f2} lv.");
        Console.WriteLine($"The discount is: {discount:f2} lv.");
    }
}
