namespace C_sharp_school_introduction.Lesson02_2_SimpleCalculationsExam;

// Exam problem: Daily Earnings
// Ivan works N days per month and earns M dollars per day.
// At the end of the year he gets a bonus of 2.5 monthly salaries. 25% of all goes for taxes.
// Print his average net earnings per day in leva (a year has 365 days), with 2 digits.
public static class DailyEarnings
{
    public static void Run()
    {
        var workDays = int.Parse(Console.ReadLine());
        var dollarsPerDay = double.Parse(Console.ReadLine());
        var dollarToLeva = double.Parse(Console.ReadLine());

        var monthlySalary = workDays * dollarsPerDay;
        var yearlyIncome = monthlySalary * 12 + monthlySalary * 2.5;
        var netIncome = yearlyIncome * 0.75;  // 25% goes for taxes
        var netIncomeInLeva = netIncome * dollarToLeva;
        var perDay = netIncomeInLeva / 365;

        Console.WriteLine($"{perDay:f2}");
    }
}
