namespace C_sharp_school_introduction.Lesson04_1_ComplexConditions;

// Problem: Cinema
// Ticket prices: Premiere 12.00, Normal 7.50, Discount 5.00 leva.
// Read the type of show, the rows and the columns of the hall.
// Print the income for a full hall with 2 digits, like "1440.00 leva".
public static class Cinema
{
    public static void Run()
    {
        var type = Console.ReadLine();
        var rows = int.Parse(Console.ReadLine());
        var columns = int.Parse(Console.ReadLine());

        var ticketPrice = 0.0;
        switch (type)
        {
            case "Premiere":
                ticketPrice = 12.00;
                break;
            case "Normal":
                ticketPrice = 7.50;
                break;
            case "Discount":
                ticketPrice = 5.00;
                break;
        }

        var income = rows * columns * ticketPrice;
        Console.WriteLine($"{income:f2} leva");
    }
}
