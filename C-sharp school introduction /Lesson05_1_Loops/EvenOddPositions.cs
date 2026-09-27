namespace C_sharp_school_introduction.Lesson05_1_Loops;

// Problem: Even / Odd Positions
// Read n numbers. For the numbers on odd positions (1st, 3rd, ...) and on even positions (2nd, 4th, ...)
// print the sum, the min and the max. If there is no min or max, print "No".
public static class EvenOddPositions
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());

        var oddSum = 0.0;
        var oddMin = double.MaxValue;
        var oddMax = double.MinValue;
        var evenSum = 0.0;
        var evenMin = double.MaxValue;
        var evenMax = double.MinValue;

        for (int position = 1; position <= n; position++)
        {
            var number = double.Parse(Console.ReadLine());

            if (position % 2 == 1)
            {
                oddSum = oddSum + number;
                if (number < oddMin)
                {
                    oddMin = number;
                }
                if (number > oddMax)
                {
                    oddMax = number;
                }
            }
            else
            {
                evenSum = evenSum + number;
                if (number < evenMin)
                {
                    evenMin = number;
                }
                if (number > evenMax)
                {
                    evenMax = number;
                }
            }
        }

        Console.WriteLine($"OddSum={oddSum},");

        if (oddMin == double.MaxValue)
        {
            Console.WriteLine("OddMin=No,");
            Console.WriteLine("OddMax=No,");
        }
        else
        {
            Console.WriteLine($"OddMin={oddMin},");
            Console.WriteLine($"OddMax={oddMax},");
        }

        Console.WriteLine($"EvenSum={evenSum},");

        if (evenMin == double.MaxValue)
        {
            Console.WriteLine("EvenMin=No,");
            Console.WriteLine("EvenMax=No");
        }
        else
        {
            Console.WriteLine($"EvenMin={evenMin},");
            Console.WriteLine($"EvenMax={evenMax}");
        }
    }
}
