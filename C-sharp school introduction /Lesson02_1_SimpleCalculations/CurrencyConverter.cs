namespace C_sharp_school_introduction.Lesson02_1_SimpleCalculations;

// * Problem: Currency Converter
// Read an amount, an input currency and an output currency (BGN, USD, EUR or GBP).
// Print the converted amount, rounded to 2 digits, followed by the output currency.
// Rates: 1 USD = 1.79549 BGN, 1 EUR = 1.95583 BGN, 1 GBP = 2.53405 BGN
public static class CurrencyConverter
{
    public static void Run()
    {
        var amount = double.Parse(Console.ReadLine());
        var inputCurrency = Console.ReadLine();
        var outputCurrency = Console.ReadLine();

        // Step 1: turn the amount into leva (BGN)
        var leva = amount;
        if (inputCurrency == "USD")
        {
            leva = amount * 1.79549;
        }
        else if (inputCurrency == "EUR")
        {
            leva = amount * 1.95583;
        }
        else if (inputCurrency == "GBP")
        {
            leva = amount * 2.53405;
        }

        // Step 2: turn the leva into the output currency
        var result = leva;
        if (outputCurrency == "USD")
        {
            result = leva / 1.79549;
        }
        else if (outputCurrency == "EUR")
        {
            result = leva / 1.95583;
        }
        else if (outputCurrency == "GBP")
        {
            result = leva / 2.53405;
        }

        Console.WriteLine($"{Math.Round(result, 2)} {outputCurrency}");
    }
}
