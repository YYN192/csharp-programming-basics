namespace C_sharp_school_introduction.Lesson04_1_ComplexConditions;

// Example: Fruit Shop
// Read a fruit, a day of the week and a quantity. Print the price with 2 digits.
// Work days:   banana 2.50, apple 1.20, orange 0.85, grapefruit 1.45, kiwi 2.70, pineapple 5.50, grapes 3.85
// Weekend:     banana 2.70, apple 1.25, orange 0.90, grapefruit 1.60, kiwi 3.00, pineapple 5.60, grapes 4.20
// If the fruit or the day is wrong, print "error".
public static class FruitShop
{
    public static void Run()
    {
        var fruit = Console.ReadLine();
        var day = Console.ReadLine();
        var quantity = double.Parse(Console.ReadLine());

        var price = -1.0;  // -1 means "we did not find a price"

        if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
        {
            if (fruit == "banana")
            {
                price = 2.50;
            }
            else if (fruit == "apple")
            {
                price = 1.20;
            }
            else if (fruit == "orange")
            {
                price = 0.85;
            }
            else if (fruit == "grapefruit")
            {
                price = 1.45;
            }
            else if (fruit == "kiwi")
            {
                price = 2.70;
            }
            else if (fruit == "pineapple")
            {
                price = 5.50;
            }
            else if (fruit == "grapes")
            {
                price = 3.85;
            }
        }
        else if (day == "Saturday" || day == "Sunday")
        {
            if (fruit == "banana")
            {
                price = 2.70;
            }
            else if (fruit == "apple")
            {
                price = 1.25;
            }
            else if (fruit == "orange")
            {
                price = 0.90;
            }
            else if (fruit == "grapefruit")
            {
                price = 1.60;
            }
            else if (fruit == "kiwi")
            {
                price = 3.00;
            }
            else if (fruit == "pineapple")
            {
                price = 5.60;
            }
            else if (fruit == "grapes")
            {
                price = 4.20;
            }
        }

        if (price >= 0)
        {
            Console.WriteLine($"{price * quantity:f2}");
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}
