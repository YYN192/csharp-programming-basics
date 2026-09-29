namespace C_sharp_school_introduction.Lesson01_2_FirstStepsInCodingExercises;

// Задача 2: Зоомагазин
// Опаковка храна за куче струва 2.50 лв., за всяко друго животно — 4 лв.
// Явор — 28.09.2026
public static class PetShop
{
    public static void Run()
    {
        var dogs = int.Parse(Console.ReadLine());
        var otherAnimals = int.Parse(Console.ReadLine());

        var total = dogs * 2.50 + otherAnimals * 4;

        Console.WriteLine($"{total} lv.");
    }
}
