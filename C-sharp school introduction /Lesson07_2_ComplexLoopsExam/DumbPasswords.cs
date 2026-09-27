namespace C_sharp_school_introduction.Lesson07_2_ComplexLoopsExam;

// Exam problem: Dumb Passwords Generator
// Read n and l and print all "dumb" passwords in alphabetical order. A password has 5 symbols:
//  1. a digit from 1 to n
//  2. a digit from 1 to n
//  3. a small letter from the first l letters of the alphabet
//  4. a small letter from the first l letters of the alphabet
//  5. a digit from 1 to n that is bigger than the first two digits
public static class DumbPasswords
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var l = int.Parse(Console.ReadLine());
        var lastLetter = (char)('a' + l - 1);

        for (int d1 = 1; d1 <= n; d1++)
        {
            for (int d2 = 1; d2 <= n; d2++)
            {
                for (char c3 = 'a'; c3 <= lastLetter; c3++)
                {
                    for (char c4 = 'a'; c4 <= lastLetter; c4++)
                    {
                        for (int d5 = Math.Max(d1, d2) + 1; d5 <= n; d5++)
                        {
                            Console.Write($"{d1}{d2}{c3}{c4}{d5} ");
                        }
                    }
                }
            }
        }

        Console.WriteLine();
    }
}
