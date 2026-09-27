namespace C_sharp_school_introduction.Lesson10_Methods;

// Problem: String Encryption
// Read n letters, encrypt each one and print everything on one line.
// Encrypting a letter, for example 'j' (ASCII code 106, first digit 1, last digit 6):
//  1. the letter with code 106 + 6 = 112 -> 'p'
//  2. the first and the last digit    -> "16"
//  3. the letter with code 106 - 1 = 105 -> 'i'
//  So 'j' -> "p16i"
public static class StringEncryption
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        var encrypted = "";

        for (int i = 0; i < n; i++)
        {
            var letter = char.Parse(Console.ReadLine());
            encrypted = encrypted + Encrypt(letter);
        }

        Console.WriteLine(encrypted);
    }

    private static string Encrypt(char letter)
    {
        int code = letter;  // a char is also a number: its ASCII code

        var lastDigit = code % 10;
        var firstDigit = code;
        while (firstDigit >= 10)
        {
            firstDigit = firstDigit / 10;
        }

        var firstSymbol = (char)(code + lastDigit);
        var lastSymbol = (char)(code - firstDigit);

        return $"{firstSymbol}{firstDigit}{lastDigit}{lastSymbol}";
    }
}
