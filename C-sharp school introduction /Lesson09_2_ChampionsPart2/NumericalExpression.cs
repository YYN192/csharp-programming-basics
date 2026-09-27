namespace C_sharp_school_introduction.Lesson09_2_ChampionsPart2;

// Champions problem: Numerical Expression
// Calculate an expression like 4+6/5+(4*9-8)/7*2= from left to right,
// WITHOUT the math rule that * and / go first. Only the brackets go first.
// The numbers are single digits (1 to 9) and brackets are never inside other brackets.
// The expression ends with "=". Print the result with 2 digits.
public static class NumericalExpression
{
    public static void Run()
    {
        var expression = Console.ReadLine();

        var result = 0.0;
        var operation = '+';

        var bracketResult = 0.0;
        var bracketOperation = '+';
        var insideBracket = false;

        for (int i = 0; i < expression.Length; i++)
        {
            var symbol = expression[i];

            if (symbol == '=')
            {
                break;
            }

            if (symbol == '(')
            {
                insideBracket = true;
                bracketResult = 0;
                bracketOperation = '+';
            }
            else if (symbol == ')')
            {
                insideBracket = false;

                // The whole bracket works like one number for the outside expression
                if (operation == '+') result = result + bracketResult;
                else if (operation == '-') result = result - bracketResult;
                else if (operation == '*') result = result * bracketResult;
                else if (operation == '/') result = result / bracketResult;
            }
            else if (char.IsDigit(symbol))
            {
                var number = symbol - '0';

                if (insideBracket)
                {
                    if (bracketOperation == '+') bracketResult = bracketResult + number;
                    else if (bracketOperation == '-') bracketResult = bracketResult - number;
                    else if (bracketOperation == '*') bracketResult = bracketResult * number;
                    else if (bracketOperation == '/') bracketResult = bracketResult / number;
                }
                else
                {
                    if (operation == '+') result = result + number;
                    else if (operation == '-') result = result - number;
                    else if (operation == '*') result = result * number;
                    else if (operation == '/') result = result / number;
                }
            }
            else
            {
                // The symbol is an operation: + - * /
                if (insideBracket)
                {
                    bracketOperation = symbol;
                }
                else
                {
                    operation = symbol;
                }
            }
        }

        // Round like in school: 110.625 -> 110.63 (the midpoint goes up, "away from zero")
        var rounded = Math.Round(result, 2, MidpointRounding.AwayFromZero);
        Console.WriteLine($"{rounded:f2}");
    }
}
