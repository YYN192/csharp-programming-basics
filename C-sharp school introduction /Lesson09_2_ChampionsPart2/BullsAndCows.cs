namespace C_sharp_school_introduction.Lesson09_2_ChampionsPart2;

// Champions problem: Bulls and Cows
// Compare a 4-digit guess with a 4-digit secret number:
//  - bull: the same digit in the same place
//  - cow:  the same digit, but in a different place
// Read the secret number, the bulls and the cows.
// Print all guesses (digits 1 to 9) that give exactly these bulls and cows, or "No".
public static class BullsAndCows
{
    public static void Run()
    {
        var secret = int.Parse(Console.ReadLine());
        var wantedBulls = int.Parse(Console.ReadLine());
        var wantedCows = int.Parse(Console.ReadLine());

        var secretDigit1 = secret / 1000;
        var secretDigit2 = secret / 100 % 10;
        var secretDigit3 = secret / 10 % 10;
        var secretDigit4 = secret % 10;

        var found = false;

        for (int d1 = 1; d1 <= 9; d1++)
        {
            for (int d2 = 1; d2 <= 9; d2++)
            {
                for (int d3 = 1; d3 <= 9; d3++)
                {
                    for (int d4 = 1; d4 <= 9; d4++)
                    {
                        var bulls = 0;
                        var cows = 0;

                        // Copies, because we "cross out" digits that we already counted
                        var s1 = secretDigit1;
                        var s2 = secretDigit2;
                        var s3 = secretDigit3;
                        var s4 = secretDigit4;
                        var g1 = d1;
                        var g2 = d2;
                        var g3 = d3;
                        var g4 = d4;

                        // Bulls: same place. Cross them out with -1 and -2 so they never match again.
                        if (g1 == s1)
                        {
                            bulls++;
                            s1 = -1;
                            g1 = -2;
                        }
                        if (g2 == s2)
                        {
                            bulls++;
                            s2 = -1;
                            g2 = -2;
                        }
                        if (g3 == s3)
                        {
                            bulls++;
                            s3 = -1;
                            g3 = -2;
                        }
                        if (g4 == s4)
                        {
                            bulls++;
                            s4 = -1;
                            g4 = -2;
                        }

                        // Cows: the same digit in another place. Cross out the secret digit we used.
                        if (g1 == s2)
                        {
                            cows++;
                            s2 = -1;
                        }
                        else if (g1 == s3)
                        {
                            cows++;
                            s3 = -1;
                        }
                        else if (g1 == s4)
                        {
                            cows++;
                            s4 = -1;
                        }

                        if (g2 == s1)
                        {
                            cows++;
                            s1 = -1;
                        }
                        else if (g2 == s3)
                        {
                            cows++;
                            s3 = -1;
                        }
                        else if (g2 == s4)
                        {
                            cows++;
                            s4 = -1;
                        }

                        if (g3 == s1)
                        {
                            cows++;
                            s1 = -1;
                        }
                        else if (g3 == s2)
                        {
                            cows++;
                            s2 = -1;
                        }
                        else if (g3 == s4)
                        {
                            cows++;
                            s4 = -1;
                        }

                        if (g4 == s1)
                        {
                            cows++;
                            s1 = -1;
                        }
                        else if (g4 == s2)
                        {
                            cows++;
                            s2 = -1;
                        }
                        else if (g4 == s3)
                        {
                            cows++;
                            s3 = -1;
                        }

                        if (bulls == wantedBulls && cows == wantedCows)
                        {
                            Console.Write($"{d1}{d2}{d3}{d4} ");
                            found = true;
                        }
                    }
                }
            }
        }

        if (found)
        {
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
