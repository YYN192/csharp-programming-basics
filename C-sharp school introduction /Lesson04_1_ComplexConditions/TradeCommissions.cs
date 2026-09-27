namespace C_sharp_school_introduction.Lesson04_1_ComplexConditions;

// Example: Trade Commissions
// Read a town and the sales and print the commission, rounded to 2 digits.
// Town      0-500   500-1000   1000-10000   over 10000
// Sofia     5%      7%         8%           12%
// Varna     4.5%    7.5%       10%          13%
// Plovdiv   5.5%    8%         12%          14.5%
// For a wrong town or negative sales print "error".
public static class TradeCommissions
{
    public static void Run()
    {
        var town = Console.ReadLine().ToLower();
        var sales = double.Parse(Console.ReadLine());

        var percent = -1.0;  // -1 means "we did not find a percent"

        if (town == "sofia")
        {
            if (sales >= 0 && sales <= 500)
            {
                percent = 5;
            }
            else if (sales > 500 && sales <= 1000)
            {
                percent = 7;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                percent = 8;
            }
            else if (sales > 10000)
            {
                percent = 12;
            }
        }
        else if (town == "varna")
        {
            if (sales >= 0 && sales <= 500)
            {
                percent = 4.5;
            }
            else if (sales > 500 && sales <= 1000)
            {
                percent = 7.5;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                percent = 10;
            }
            else if (sales > 10000)
            {
                percent = 13;
            }
        }
        else if (town == "plovdiv")
        {
            if (sales >= 0 && sales <= 500)
            {
                percent = 5.5;
            }
            else if (sales > 500 && sales <= 1000)
            {
                percent = 8;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                percent = 12;
            }
            else if (sales > 10000)
            {
                percent = 14.5;
            }
        }

        if (percent >= 0)
        {
            var commission = sales * percent / 100;
            Console.WriteLine($"{commission:f2}");
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}
