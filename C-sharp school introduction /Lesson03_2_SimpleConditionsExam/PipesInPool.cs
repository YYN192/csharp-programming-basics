namespace C_sharp_school_introduction.Lesson03_2_SimpleConditionsExam;

// Exam problem: Pipes in a Pool
// A pool with volume V is filled by two pipes (P1 and P2 liters per hour) for H hours.
// Print how full the pool is and how much each pipe gave (whole percents, no rounding),
// or, if the pool overflows, by how many liters.
public static class PipesInPool
{
    public static void Run()
    {
        var volume = int.Parse(Console.ReadLine());
        var pipe1 = int.Parse(Console.ReadLine());
        var pipe2 = int.Parse(Console.ReadLine());
        var hours = double.Parse(Console.ReadLine());

        var water1 = pipe1 * hours;
        var water2 = pipe2 * hours;
        var totalWater = water1 + water2;

        if (totalWater <= volume)
        {
            var fullPercent = Math.Truncate(totalWater / volume * 100);
            var pipe1Percent = Math.Truncate(water1 / totalWater * 100);
            var pipe2Percent = Math.Truncate(water2 / totalWater * 100);
            Console.WriteLine($"The pool is {fullPercent}% full. Pipe 1: {pipe1Percent}%. Pipe 2: {pipe2Percent}%.");
        }
        else
        {
            var overflow = totalWater - volume;
            Console.WriteLine($"For {hours} hours the pool overflows with {overflow} liters.");
        }
    }
}
