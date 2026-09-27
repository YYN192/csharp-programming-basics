namespace C_sharp_school_introduction.Lesson10_Methods;

// Problem: Numbers to Words
// Read n, then n whole numbers. Print each number with English words, for example:
// 999 -> "nine-hundred and ninety nine", -420 -> "minus four-hundred and twenty", 15 -> "fifteen"
// Numbers bigger than 999 -> "too large", smaller than -999 -> "too small".
public static class NumbersToWords
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());
            Letterize(number);
        }
    }

    private static void Letterize(int number)
    {
        if (number > 999)
        {
            Console.WriteLine("too large");
            return;
        }

        if (number < -999)
        {
            Console.WriteLine("too small");
            return;
        }

        var text = "";
        if (number < 0)
        {
            text = "minus ";
            number = -number;
        }

        var hundreds = number / 100;
        var lastTwoDigits = number % 100;

        if (hundreds > 0)
        {
            text = text + GetOnesWord(hundreds) + "-hundred";
            if (lastTwoDigits > 0)
            {
                text = text + " and " + GetTwoDigitsWords(lastTwoDigits);
            }
        }
        else
        {
            text = text + GetTwoDigitsWords(lastTwoDigits);
        }

        Console.WriteLine(text);
    }

    // 0 to 99 in words
    private static string GetTwoDigitsWords(int number)
    {
        if (number < 20)
        {
            return GetOnesWord(number);
        }

        var tensWord = GetTensWord(number / 10);
        var ones = number % 10;
        if (ones == 0)
        {
            return tensWord;
        }
        return tensWord + " " + GetOnesWord(ones);
    }

    // 0 to 19 in words
    private static string GetOnesWord(int number)
    {
        switch (number)
        {
            case 0: return "zero";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            case 10: return "ten";
            case 11: return "eleven";
            case 12: return "twelve";
            case 13: return "thirteen";
            case 14: return "fourteen";
            case 15: return "fifteen";
            case 16: return "sixteen";
            case 17: return "seventeen";
            case 18: return "eighteen";
            default: return "nineteen";
        }
    }

    // 2 -> twenty, 3 -> thirty, ..., 9 -> ninety
    private static string GetTensWord(int tens)
    {
        switch (tens)
        {
            case 2: return "twenty";
            case 3: return "thirty";
            case 4: return "forty";
            case 5: return "fifty";
            case 6: return "sixty";
            case 7: return "seventy";
            case 8: return "eighty";
            default: return "ninety";
        }
    }
}
