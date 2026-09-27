namespace C_sharp_school_introduction.Lesson09_1_ChampionsPart1;

// Champions problem: Crossing Sequences
// Sequence 1 (Tribonacci): every number is the sum of the 3 numbers before it.
// Sequence 2 (spiral): start with a number and add step, step, 2*step, 2*step, 3*step, 3*step, ...
// Example: start 5, step 2 -> 5, 7, 9, 13, 17, 23, 29, 37, ...
// Print the first number that is in both sequences, or "No" if there is none up to 1 000 000.
//
// Idea: both sequences grow. We always move forward the one that is behind,
// until the two current numbers are equal.
public static class CrossingSequences
{
    public static void Run()
    {
        var tribonacci1 = int.Parse(Console.ReadLine());
        var tribonacci2 = int.Parse(Console.ReadLine());
        var tribonacci3 = int.Parse(Console.ReadLine());
        var spiralCurrent = int.Parse(Console.ReadLine());
        var spiralStep = int.Parse(Console.ReadLine());

        // The current Tribonacci number is tribonacci1. The next two are waiting in line.
        var spiralTurns = 0;
        var spiralMultiplier = 1;

        while (tribonacci1 <= 1000000 && spiralCurrent <= 1000000)
        {
            if (tribonacci1 == spiralCurrent)
            {
                Console.WriteLine(tribonacci1);
                return;
            }

            if (tribonacci1 < spiralCurrent)
            {
                // Next Tribonacci number: everything moves one place forward
                var next = tribonacci1 + tribonacci2 + tribonacci3;
                tribonacci1 = tribonacci2;
                tribonacci2 = tribonacci3;
                tribonacci3 = next;
            }
            else
            {
                // Next spiral number: after every 2 turns the multiplier grows by 1
                spiralCurrent = spiralCurrent + spiralStep * spiralMultiplier;
                spiralTurns++;
                if (spiralTurns % 2 == 0)
                {
                    spiralMultiplier++;
                }
            }
        }

        Console.WriteLine("No");
    }
}
