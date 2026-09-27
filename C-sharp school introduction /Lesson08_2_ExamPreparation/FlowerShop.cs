namespace C_sharp_school_introduction.Lesson08_2_ExamPreparation;

// Exam problem: Flower Shop
// Prices:               chrysanthemums   roses   tulips
//   Spring / Summer     2.00             4.10    2.50
//   Autumn / Winter     3.75             4.50    4.15
// On holidays (Y) all prices are 15% higher. Then these discounts are applied one after another:
//   - more than 7 tulips in Spring: 5%
//   - 10 or more roses in Winter: 10%
//   - more than 20 flowers in total (any season): 20%
// Making the bouquet always costs 2 leva more. Print the price with 2 digits.
public static class FlowerShop
{
    public static void Run()
    {
        var chrysanthemums = int.Parse(Console.ReadLine());
        var roses = int.Parse(Console.ReadLine());
        var tulips = int.Parse(Console.ReadLine());
        var season = Console.ReadLine();
        var isHoliday = Console.ReadLine();

        var chrysanthemumPrice = 3.75;
        var rosePrice = 4.50;
        var tulipPrice = 4.15;
        if (season == "Spring" || season == "Summer")
        {
            chrysanthemumPrice = 2.00;
            rosePrice = 4.10;
            tulipPrice = 2.50;
        }

        var price = chrysanthemums * chrysanthemumPrice + roses * rosePrice + tulips * tulipPrice;

        if (isHoliday == "Y")
        {
            price = price * 1.15;
        }

        if (tulips > 7 && season == "Spring")
        {
            price = price * 0.95;
        }

        if (roses >= 10 && season == "Winter")
        {
            price = price * 0.90;
        }

        if (chrysanthemums + roses + tulips > 20)
        {
            price = price * 0.80;
        }

        price = price + 2;  // making the bouquet

        Console.WriteLine($"{price:f2}");
    }
}
