namespace C_sharp_school_introduction.Lesson04_2_ComplexConditionsExam;

// Exam problem: Match Tickets
// Tickets: VIP 499.99 leva, Normal 249.99 leva.
// Part of the budget goes for transport, depending on the group size:
// 1-4 people: 75%, 5-9: 60%, 10-24: 50%, 25-49: 40%, 50 or more: 25%.
// Print if the rest of the money is enough for the tickets and how much is left or missing.
public static class MatchTickets
{
    public static void Run()
    {
        var budget = double.Parse(Console.ReadLine());
        var category = Console.ReadLine();
        var people = int.Parse(Console.ReadLine());

        var transportPercent = 0.0;
        if (people <= 4)
        {
            transportPercent = 0.75;
        }
        else if (people <= 9)
        {
            transportPercent = 0.60;
        }
        else if (people <= 24)
        {
            transportPercent = 0.50;
        }
        else if (people <= 49)
        {
            transportPercent = 0.40;
        }
        else
        {
            transportPercent = 0.25;
        }

        var ticketPrice = 249.99;
        if (category == "VIP")
        {
            ticketPrice = 499.99;
        }

        var moneyLeft = budget - budget * transportPercent;
        var ticketsCost = ticketPrice * people;

        if (moneyLeft >= ticketsCost)
        {
            Console.WriteLine($"Yes! You have {moneyLeft - ticketsCost:f2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! You need {ticketsCost - moneyLeft:f2} leva.");
        }
    }
}
