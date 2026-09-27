namespace C_sharp_school_introduction.Lesson03_2_SimpleConditionsExam;

// Exam problem: Harvest
// From a vineyard of X square meters, 40% of the grapes go for wine.
// 1 square meter gives Y kg grapes. 1 liter of wine needs 2.5 kg grapes.
// We need Z liters of wine. Is it enough? If yes, the rest is shared between the workers.
public static class Harvest
{
    public static void Run()
    {
        var area = int.Parse(Console.ReadLine());
        var grapesPerMeter = double.Parse(Console.ReadLine());
        var neededWine = int.Parse(Console.ReadLine());
        var workers = int.Parse(Console.ReadLine());

        var grapesForWine = area * grapesPerMeter * 0.40;
        var wine = grapesForWine / 2.5;

        if (wine < neededWine)
        {
            var missing = Math.Floor(neededWine - wine);
            Console.WriteLine($"It will be a tough winter! More {missing} liters wine needed.");
        }
        else
        {
            var leftWine = Math.Ceiling(wine - neededWine);
            var winePerWorker = Math.Ceiling((wine - neededWine) / workers);
            Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
            Console.WriteLine($"{leftWine} liters left -> {winePerWorker} liters per person.");
        }
    }
}
