namespace C_sharp_school_introduction.Lesson02_1_SimpleCalculations;

// Lab: *** Catch the Button!
// In the book this is a Windows Forms game where the button runs away from the mouse.
// Console version: the button hides somewhere on a 5 x 5 board.
// Guess its row and column. Every time you miss, it runs away to a new random place!
public static class CatchTheButton
{
    public static void Run()
    {
        var random = new Random();
        var buttonRow = random.Next(1, 6);
        var buttonCol = random.Next(1, 6);
        var tries = 0;

        Console.WriteLine("The button is hiding on a 5 x 5 board. Catch it!");
        while (true)
        {
            Console.Write("Row (1-5): ");
            var row = int.Parse(Console.ReadLine());
            Console.Write("Column (1-5): ");
            var col = int.Parse(Console.ReadLine());
            tries++;

            if (row == buttonRow && col == buttonCol)
            {
                Console.WriteLine($"Congratulations! You caught the button after {tries} tries!");
                break;
            }

            Console.WriteLine("Missed! The button ran away...");
            buttonRow = random.Next(1, 6);
            buttonCol = random.Next(1, 6);
        }
    }
}
