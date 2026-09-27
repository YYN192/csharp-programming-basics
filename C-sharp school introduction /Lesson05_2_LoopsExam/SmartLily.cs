namespace C_sharp_school_introduction.Lesson05_2_LoopsExam;

// Exam problem: Smart Lily
// On odd birthdays Lily gets a toy. On even birthdays she gets money: 10 leva, then 20, then 30...
// Her brother takes 1 leva every time she gets money. She sells every toy for P leva.
// Can she buy a washing machine for X leva? Print "Yes! <money left>" or "No! <money missing>".
public static class SmartLily
{
    public static void Run()
    {
        var age = int.Parse(Console.ReadLine());
        var washingMachinePrice = double.Parse(Console.ReadLine());
        var toyPrice = int.Parse(Console.ReadLine());

        var savedMoney = 0.0;
        var moneyGift = 10;
        var toys = 0;

        for (int birthday = 1; birthday <= age; birthday++)
        {
            if (birthday % 2 == 0)
            {
                savedMoney = savedMoney + moneyGift - 1;  // her brother takes 1 leva
                moneyGift = moneyGift + 10;
            }
            else
            {
                toys++;
            }
        }

        var totalMoney = savedMoney + toys * toyPrice;

        if (totalMoney >= washingMachinePrice)
        {
            Console.WriteLine($"Yes! {totalMoney - washingMachinePrice:f2}");
        }
        else
        {
            Console.WriteLine($"No! {washingMachinePrice - totalMoney:f2}");
        }
    }
}
