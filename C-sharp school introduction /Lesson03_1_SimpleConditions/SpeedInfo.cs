namespace C_sharp_school_introduction.Lesson03_1_SimpleConditions;

// Problem: Speed Info
// Read a speed and print:
// up to 10 -> "slow", up to 50 -> "average", up to 150 -> "fast",
// up to 1000 -> "ultra fast", more -> "extremely fast"
public static class SpeedInfo
{
    public static void Run()
    {
        var speed = double.Parse(Console.ReadLine());

        if (speed <= 10)
        {
            Console.WriteLine("slow");
        }
        else if (speed <= 50)
        {
            Console.WriteLine("average");
        }
        else if (speed <= 150)
        {
            Console.WriteLine("fast");
        }
        else if (speed <= 1000)
        {
            Console.WriteLine("ultra fast");
        }
        else
        {
            Console.WriteLine("extremely fast");
        }
    }
}
