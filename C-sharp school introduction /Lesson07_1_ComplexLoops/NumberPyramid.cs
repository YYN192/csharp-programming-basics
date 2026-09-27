namespace C_sharp_school_introduction.Lesson07_1_ComplexLoops;

// Problem: Number Pyramid
// Print the numbers 1...n like a pyramid: 1 number on the 1st row, 2 on the 2nd, 3 on the 3rd...
// The last row has as many numbers as are left. Example for n = 7:
// 1
// 2 3
// 4 5 6
// 7
public static class NumberPyramid
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var number = 1;

        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                if (col > 1)
                {
                    Console.Write(" ");
                }

                Console.Write(number);
                number++;

                if (number > n)
                {
                    break;
                }
            }

            Console.WriteLine();

            if (number > n)
            {
                break;
            }
        }
    }
}
