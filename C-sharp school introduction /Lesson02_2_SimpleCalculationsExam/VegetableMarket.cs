namespace C_sharp_school_introduction.Lesson02_2_SimpleCalculationsExam;

// Exam problem: Vegetable Market
// Vegetables cost N leva per kg and fruits cost M leva per kg.
// Read the prices and the kilograms and print the total income in euro (1 EUR = 1.94 leva).
public static class VegetableMarket
{
    public static void Run()
    {
        var vegetablePrice = double.Parse(Console.ReadLine());
        var fruitPrice = double.Parse(Console.ReadLine());
        var vegetableKilos = int.Parse(Console.ReadLine());
        var fruitKilos = int.Parse(Console.ReadLine());

        var totalLeva = vegetablePrice * vegetableKilos + fruitPrice * fruitKilos;
        var totalEuro = totalLeva / 1.94;

        Console.WriteLine(totalEuro);
    }
}
