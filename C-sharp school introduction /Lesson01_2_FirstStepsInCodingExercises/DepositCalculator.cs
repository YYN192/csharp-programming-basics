namespace C_sharp_school_introduction.Lesson01_2_FirstStepsInCodingExercises;

// Задача 6: Калкулатор за депозити
// сума = депозит + срок * ((депозит * годишна лихва) / 12)
// Явор — 28.09.2026
public static class DepositCalculator
{
    public static void Run()
    {
        var deposit = double.Parse(Console.ReadLine());
        var months = int.Parse(Console.ReadLine());
        var yearlyInterest = double.Parse(Console.ReadLine());

        var interestPerMonth = deposit * (yearlyInterest / 100) / 12;

        Console.WriteLine(deposit + months * interestPerMonth);
    }
}
