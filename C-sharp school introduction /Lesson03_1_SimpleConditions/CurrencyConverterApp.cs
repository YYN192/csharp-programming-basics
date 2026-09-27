namespace C_sharp_school_introduction.Lesson03_1_SimpleConditions;

// Lab: Currency Converter (GUI app in the book)
// In the book this is a Windows Forms app with a number box and a currency drop-down.
// Console version: read an amount in leva and a currency (EUR, USD or GBP),
// then print the converted amount rounded to 2 digits.
public static class CurrencyConverterApp
{
    public static void Run()
    {
        var amount = double.Parse(Console.ReadLine());
        var currency = Console.ReadLine();

        var converted = amount;
        if (currency == "EUR")
        {
            converted = amount / 1.95583;
        }
        else if (currency == "USD")
        {
            converted = amount / 1.80810;
        }
        else if (currency == "GBP")
        {
            converted = amount / 2.54990;
        }

        Console.WriteLine(amount + " лв. = " + Math.Round(converted, 2) + " " + currency);
    }
}
