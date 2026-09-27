namespace C_sharp_school_introduction.Lesson09_1_ChampionsPart1;

// Champions problem: Five Special Letters
// Letter weights: a = 5, b = -12, c = 47, d = 7, e = -32
// The weight of a word: first remove the repeated letters (keep the first one),
// then add 1 * weight(1st letter) + 2 * weight(2nd letter) + ...
// Example: "bcddc" -> "bcd" -> 1 * (-12) + 2 * 47 + 3 * 7 = 103
// Read start and end. Print all 5-letter words made of a-e whose weight is between them, or "No".
public static class FiveSpecialLetters
{
    public static void Run()
    {
        var start = int.Parse(Console.ReadLine());
        var end = int.Parse(Console.ReadLine());
        var found = false;

        for (char c1 = 'a'; c1 <= 'e'; c1++)
        {
            for (char c2 = 'a'; c2 <= 'e'; c2++)
            {
                for (char c3 = 'a'; c3 <= 'e'; c3++)
                {
                    for (char c4 = 'a'; c4 <= 'e'; c4++)
                    {
                        for (char c5 = 'a'; c5 <= 'e'; c5++)
                        {
                            var word = $"{c1}{c2}{c3}{c4}{c5}";

                            // Remove the repeated letters
                            var uniqueLetters = "";
                            for (int i = 0; i < word.Length; i++)
                            {
                                if (!uniqueLetters.Contains(word[i]))
                                {
                                    uniqueLetters = uniqueLetters + word[i];
                                }
                            }

                            // Calculate the weight
                            var weight = 0;
                            for (int i = 0; i < uniqueLetters.Length; i++)
                            {
                                var letterWeight = 0;
                                switch (uniqueLetters[i])
                                {
                                    case 'a':
                                        letterWeight = 5;
                                        break;
                                    case 'b':
                                        letterWeight = -12;
                                        break;
                                    case 'c':
                                        letterWeight = 47;
                                        break;
                                    case 'd':
                                        letterWeight = 7;
                                        break;
                                    case 'e':
                                        letterWeight = -32;
                                        break;
                                }

                                weight = weight + (i + 1) * letterWeight;
                            }

                            if (weight >= start && weight <= end)
                            {
                                Console.Write(word + " ");
                                found = true;
                            }
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
