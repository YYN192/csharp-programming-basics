namespace C_sharp_school_introduction.Lesson05_2_LoopsExam;

// Exam problem: Back to the Past
// Ivancho is 18 and goes back to the year 1800 with some money.
// Every even year he spends 12 000 dollars.
// Every odd year he spends 12 000 + 50 * (his age in that year).
// Will the money last until the given year (including it)?
public static class BackToThePast
{
    public static void Run()
    {
        var money = double.Parse(Console.ReadLine());
        var lastYear = int.Parse(Console.ReadLine());

        var age = 18;
        for (int year = 1800; year <= lastYear; year++)
        {
            if (year % 2 == 0)
            {
                money = money - 12000;
            }
            else
            {
                money = money - (12000 + 50 * age);
            }

            age++;
        }

        if (money >= 0)
        {
            Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
        }
        else
        {
            Console.WriteLine($"He will need {Math.Abs(money):f2} dollars to survive.");
        }
    }
}
