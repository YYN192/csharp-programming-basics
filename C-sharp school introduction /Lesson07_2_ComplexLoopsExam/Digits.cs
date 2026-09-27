namespace C_sharp_school_introduction.Lesson07_2_ComplexLoopsExam;

// Exam problem: Digits
// Read a 3-digit number. Print N rows with M numbers on each row, where
// N = first digit + second digit, M = first digit + third digit.
// Before printing each number, change it:
//  - if it can be divided by 5, subtract the first digit
//  - else, if it can be divided by 3, subtract the second digit
//  - else, add the third digit
// (the digits are always the digits of the number we read at the start)
public static class Digits
{
    public static void Run()
    {
        var number = int.Parse(Console.ReadLine());

        var firstDigit = number / 100;
        var secondDigit = number / 10 % 10;
        var thirdDigit = number % 10;

        var rows = firstDigit + secondDigit;
        var cols = firstDigit + thirdDigit;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (number % 5 == 0)
                {
                    number = number - firstDigit;
                }
                else if (number % 3 == 0)
                {
                    number = number - secondDigit;
                }
                else
                {
                    number = number + thirdDigit;
                }

                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
