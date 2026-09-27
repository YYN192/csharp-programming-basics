namespace C_sharp_school_introduction.Lesson09_2_ChampionsPart2;

// Champions problem: Passion Shopping Days
// Read Lina's money. After "mall.Enter" every line is a list of actions, until "mall.Exit".
// Every character is one action:
//  - a capital letter: she pays 50% of the character's ASCII code
//  - a small letter:   she pays 30% of the character's ASCII code
//  - '%': she spends half of her money
//  - '*': she takes 10 leva from her card (adds 10 to her money, not a purchase)
//  - anything else:    she pays the full ASCII code
// She doesn't buy things she can't pay for. Print the number of purchases and the money left.
public static class PassionShoppingDays
{
    public static void Run()
    {
        var money = double.Parse(Console.ReadLine());
        var purchases = 0;

        // Skip everything until Lina enters the mall
        while (Console.ReadLine() != "mall.Enter")
        {
        }

        var line = Console.ReadLine();
        while (line != "mall.Exit")
        {
            for (int i = 0; i < line.Length; i++)
            {
                var symbol = line[i];

                if (symbol == '*')
                {
                    money = money + 10;
                    continue;
                }

                // A char is also a number (its ASCII code): 'd' is 100, 'A' is 65
                var price = 0.0;
                if (symbol == '%')
                {
                    price = money / 2;
                }
                else if (char.IsUpper(symbol))
                {
                    price = symbol * 0.50;
                }
                else if (char.IsLower(symbol))
                {
                    price = symbol * 0.30;
                }
                else
                {
                    price = symbol;
                }

                if (price <= money)
                {
                    money = money - price;
                    purchases++;
                }
            }

            line = Console.ReadLine();
        }

        if (purchases == 0)
        {
            Console.WriteLine($"No purchases. Money left: {money:f2} lv.");
        }
        else
        {
            Console.WriteLine($"{purchases} purchases. Money left: {money:f2} lv.");
        }
    }
}
