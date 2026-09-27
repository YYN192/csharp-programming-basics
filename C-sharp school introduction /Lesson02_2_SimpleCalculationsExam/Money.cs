namespace C_sharp_school_introduction.Lesson02_2_SimpleCalculationsExam;

// Exam problem: Money
// Pesho has bitcoins and Chinese yuans and wants to exchange them for euro.
// 1 bitcoin = 1168 leva, 1 yuan = 0.15 dollars, 1 dollar = 1.76 leva, 1 euro = 1.95 leva.
// The exchange office takes a commission (in percent) from the final sum in euro.
public static class Money
{
    public static void Run()
    {
        var bitcoins = int.Parse(Console.ReadLine());
        var yuans = double.Parse(Console.ReadLine());
        var commissionPercent = double.Parse(Console.ReadLine());

        // First turn everything into leva
        var bitcoinsInLeva = bitcoins * 1168;
        var yuansInDollars = yuans * 0.15;
        var dollarsInLeva = yuansInDollars * 1.76;
        var totalLeva = bitcoinsInLeva + dollarsInLeva;

        // Then turn the leva into euro and take away the commission
        var euro = totalLeva / 1.95;
        var commission = euro * commissionPercent / 100;
        var result = euro - commission;

        Console.WriteLine(result);
    }
}
