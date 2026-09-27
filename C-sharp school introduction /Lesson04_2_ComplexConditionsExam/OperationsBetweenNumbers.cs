namespace C_sharp_school_introduction.Lesson04_2_ComplexConditionsExam;

// Exam problem: Operations Between Numbers
// Read two whole numbers N1 and N2 and an operator: +, -, *, / or %.
//  - for +, - and *: print "N1 op N2 = result - even/odd"
//  - for /: print "N1 / N2 = result" with 2 digits
//  - for %: print "N1 % N2 = remainder"
//  - dividing by 0: print "Cannot divide N1 by zero"
public static class OperationsBetweenNumbers
{
    public static void Run()
    {
        var n1 = int.Parse(Console.ReadLine());
        var n2 = int.Parse(Console.ReadLine());
        var op = Console.ReadLine();

        if (op == "+" || op == "-" || op == "*")
        {
            var result = 0;
            if (op == "+")
            {
                result = n1 + n2;
            }
            else if (op == "-")
            {
                result = n1 - n2;
            }
            else
            {
                result = n1 * n2;
            }

            var evenOrOdd = "odd";
            if (result % 2 == 0)
            {
                evenOrOdd = "even";
            }

            Console.WriteLine($"{n1} {op} {n2} = {result} - {evenOrOdd}");
        }
        else if (n2 == 0)
        {
            Console.WriteLine($"Cannot divide {n1} by zero");
        }
        else if (op == "/")
        {
            var result = (double)n1 / n2;
            Console.WriteLine($"{n1} / {n2} = {result:f2}");
        }
        else if (op == "%")
        {
            Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
        }
    }
}
