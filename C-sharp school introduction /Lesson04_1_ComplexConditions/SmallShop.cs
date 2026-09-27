namespace C_sharp_school_introduction.Lesson04_1_ComplexConditions;

// Example: Small Shop
// Read a product, a town and a quantity and print the price.
// product / town   Sofia   Plovdiv   Varna
// coffee           0.50    0.40      0.45
// water            0.80    0.70      0.70
// beer             1.20    1.15      1.10
// sweets           1.45    1.30      1.35
// peanuts          1.60    1.50      1.55
public static class SmallShop
{
    public static void Run()
    {
        var product = Console.ReadLine().ToLower();
        var town = Console.ReadLine().ToLower();
        var quantity = double.Parse(Console.ReadLine());

        var price = 0.0;
        if (town == "sofia")
        {
            if (product == "coffee")
            {
                price = 0.50;
            }
            else if (product == "water")
            {
                price = 0.80;
            }
            else if (product == "beer")
            {
                price = 1.20;
            }
            else if (product == "sweets")
            {
                price = 1.45;
            }
            else if (product == "peanuts")
            {
                price = 1.60;
            }
        }
        else if (town == "plovdiv")
        {
            if (product == "coffee")
            {
                price = 0.40;
            }
            else if (product == "water")
            {
                price = 0.70;
            }
            else if (product == "beer")
            {
                price = 1.15;
            }
            else if (product == "sweets")
            {
                price = 1.30;
            }
            else if (product == "peanuts")
            {
                price = 1.50;
            }
        }
        else if (town == "varna")
        {
            if (product == "coffee")
            {
                price = 0.45;
            }
            else if (product == "water")
            {
                price = 0.70;
            }
            else if (product == "beer")
            {
                price = 1.10;
            }
            else if (product == "sweets")
            {
                price = 1.35;
            }
            else if (product == "peanuts")
            {
                price = 1.55;
            }
        }

        Console.WriteLine(Math.Round(price * quantity, 2));
    }
}
