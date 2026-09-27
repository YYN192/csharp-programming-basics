namespace C_sharp_school_introduction.Lesson03_1_SimpleConditions;

// * Problem: Number from 0 to 100 in Words
// Read a number from 0 to 100 and print it with English words, e.g. 42 -> "forty two".
public static class NumberToWords
{
    public static void Run()
    {
        var number = int.Parse(Console.ReadLine());

        if (number == 100)
        {
            Console.WriteLine("one hundred");
        }
        else if (number < 20)
        {
            // 0 to 19 have their own special words
            var word = "";
            if (number == 0)
            {
                word = "zero";
            }
            else if (number == 1)
            {
                word = "one";
            }
            else if (number == 2)
            {
                word = "two";
            }
            else if (number == 3)
            {
                word = "three";
            }
            else if (number == 4)
            {
                word = "four";
            }
            else if (number == 5)
            {
                word = "five";
            }
            else if (number == 6)
            {
                word = "six";
            }
            else if (number == 7)
            {
                word = "seven";
            }
            else if (number == 8)
            {
                word = "eight";
            }
            else if (number == 9)
            {
                word = "nine";
            }
            else if (number == 10)
            {
                word = "ten";
            }
            else if (number == 11)
            {
                word = "eleven";
            }
            else if (number == 12)
            {
                word = "twelve";
            }
            else if (number == 13)
            {
                word = "thirteen";
            }
            else if (number == 14)
            {
                word = "fourteen";
            }
            else if (number == 15)
            {
                word = "fifteen";
            }
            else if (number == 16)
            {
                word = "sixteen";
            }
            else if (number == 17)
            {
                word = "seventeen";
            }
            else if (number == 18)
            {
                word = "eighteen";
            }
            else if (number == 19)
            {
                word = "nineteen";
            }

            Console.WriteLine(word);
        }
        else
        {
            // 20 to 99: a word for the tens (forty) and a word for the ones (two)
            var tens = number / 10;
            var ones = number % 10;

            var tensWord = "";
            if (tens == 2)
            {
                tensWord = "twenty";
            }
            else if (tens == 3)
            {
                tensWord = "thirty";
            }
            else if (tens == 4)
            {
                tensWord = "forty";
            }
            else if (tens == 5)
            {
                tensWord = "fifty";
            }
            else if (tens == 6)
            {
                tensWord = "sixty";
            }
            else if (tens == 7)
            {
                tensWord = "seventy";
            }
            else if (tens == 8)
            {
                tensWord = "eighty";
            }
            else if (tens == 9)
            {
                tensWord = "ninety";
            }

            var onesWord = "";
            if (ones == 1)
            {
                onesWord = "one";
            }
            else if (ones == 2)
            {
                onesWord = "two";
            }
            else if (ones == 3)
            {
                onesWord = "three";
            }
            else if (ones == 4)
            {
                onesWord = "four";
            }
            else if (ones == 5)
            {
                onesWord = "five";
            }
            else if (ones == 6)
            {
                onesWord = "six";
            }
            else if (ones == 7)
            {
                onesWord = "seven";
            }
            else if (ones == 8)
            {
                onesWord = "eight";
            }
            else if (ones == 9)
            {
                onesWord = "nine";
            }

            if (ones == 0)
            {
                Console.WriteLine(tensWord);
            }
            else
            {
                Console.WriteLine(tensWord + " " + onesWord);
            }
        }
    }
}
