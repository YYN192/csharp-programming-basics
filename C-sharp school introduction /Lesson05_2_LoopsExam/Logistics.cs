namespace C_sharp_school_introduction.Lesson05_2_LoopsExam;

// Exam problem: Logistics
// Each load goes with a different vehicle depending on its tons:
//  - up to 3 tons: minibus, 200 leva per ton
//  - 4 to 11 tons: truck, 175 leva per ton
//  - over 11 tons: train, 120 leva per ton
// Print the average price per ton and what percent of the tons went with each vehicle.
public static class Logistics
{
    public static void Run()
    {
        var loads = int.Parse(Console.ReadLine());
        var minibusTons = 0;
        var truckTons = 0;
        var trainTons = 0;

        for (int i = 0; i < loads; i++)
        {
            var tons = int.Parse(Console.ReadLine());

            if (tons <= 3)
            {
                minibusTons = minibusTons + tons;
            }
            else if (tons <= 11)
            {
                truckTons = truckTons + tons;
            }
            else
            {
                trainTons = trainTons + tons;
            }
        }

        var totalTons = minibusTons + truckTons + trainTons;
        var totalPrice = minibusTons * 200 + truckTons * 175 + trainTons * 120;
        var averagePrice = (double)totalPrice / totalTons;

        Console.WriteLine($"{averagePrice:f2}");
        Console.WriteLine($"{minibusTons * 100.0 / totalTons:f2}%");
        Console.WriteLine($"{truckTons * 100.0 / totalTons:f2}%");
        Console.WriteLine($"{trainTons * 100.0 / totalTons:f2}%");
    }
}
