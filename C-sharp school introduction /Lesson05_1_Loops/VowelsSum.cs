namespace C_sharp_school_introduction.Lesson05_1_Loops;

// Example: Sum of Vowels
// Read a text and sum the values of its vowels: a = 1, e = 2, i = 3, o = 4, u = 5
public static class VowelsSum
{
    public static void Run()
    {
        var text = Console.ReadLine();
        var sum = 0;

        for (int i = 0; i < text.Length; i++)
        {
            switch (text[i])
            {
                case 'a':
                    sum = sum + 1;
                    break;
                case 'e':
                    sum = sum + 2;
                    break;
                case 'i':
                    sum = sum + 3;
                    break;
                case 'o':
                    sum = sum + 4;
                    break;
                case 'u':
                    sum = sum + 5;
                    break;
            }
        }

        Console.WriteLine(sum);
    }
}
