namespace C_sharp_school_introduction.Lesson08_2_ExamPreparation;

// Exam problem: Changing Tiles
// Haralambi wants new triangle tiles on his rectangular bathroom floor.
// Read: his money, the floor width and length, the triangle side and height,
// the price of one tile and the money for the worker.
// Tiles needed = floor area / tile area, rounded up, plus 5 extra tiles.
// Print how much money is left, or how much more he needs.
public static class ChangingTiles
{
    public static void Run()
    {
        var money = double.Parse(Console.ReadLine());
        var floorWidth = double.Parse(Console.ReadLine());
        var floorLength = double.Parse(Console.ReadLine());
        var triangleSide = double.Parse(Console.ReadLine());
        var triangleHeight = double.Parse(Console.ReadLine());
        var tilePrice = double.Parse(Console.ReadLine());
        var workerPrice = double.Parse(Console.ReadLine());

        var floorArea = floorWidth * floorLength;
        var tileArea = triangleSide * triangleHeight / 2;
        var tilesNeeded = Math.Ceiling(floorArea / tileArea) + 5;

        var totalCost = tilesNeeded * tilePrice + workerPrice;

        if (money >= totalCost)
        {
            Console.WriteLine($"{money - totalCost:f2} lv left.");
        }
        else
        {
            Console.WriteLine($"You'll need {totalCost - money:f2} lv more.");
        }
    }
}
