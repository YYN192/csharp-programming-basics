namespace C_sharp_school_introduction.Lesson03_2_SimpleConditionsExam;

// Exam problem: Transport Price
// A student must travel n kilometers. He can choose:
//  - Taxi: start fee 0.70 leva, day rate 0.79 leva/km, night rate 0.90 leva/km
//  - Bus: 0.09 leva/km, only for 20 km or more
//  - Train: 0.06 leva/km, only for 100 km or more
// Read n and "day" or "night" and print the price of the cheapest transport.
public static class TransportPrice
{
    public static void Run()
    {
        var kilometers = int.Parse(Console.ReadLine());
        var timeOfDay = Console.ReadLine();

        // The train is the cheapest, then the bus, then the taxi.
        var price = 0.0;
        if (kilometers >= 100)
        {
            price = kilometers * 0.06;
        }
        else if (kilometers >= 20)
        {
            price = kilometers * 0.09;
        }
        else if (timeOfDay == "day")
        {
            price = 0.70 + kilometers * 0.79;
        }
        else
        {
            price = 0.70 + kilometers * 0.90;
        }

        Console.WriteLine(Math.Round(price, 2));
    }
}
