namespace C_sharp_school_introduction.Lesson07_1_ComplexLoops;

// Lab: Web Game "Shoot the Fruits!" (a web app in the book)
// Console version of the game:
//  - The board has 3 rows and 9 columns with fruits (A = apple, B = banana, O = orange, K = kiwi)
//    and dynamite (D).
//  - You shoot a column from the top or from the bottom. The first fruit hit disappears
//    and you get 1 point. If you hit dynamite, the fruits explode and the game is over!
//  - Aiming is not perfect: sometimes the shot goes one column to the left or right.
public static class FruitGame
{
    public static void Run()
    {
        var random = new Random();
        var rows = 3;
        var cols = 9;
        var fruits = new string[rows, cols];  // a table with 3 rows and 9 columns
        var score = 0;
        var gameOver = false;
        var needNewBoard = true;

        while (true)
        {
            if (needNewBoard)
            {
                // Put a random fruit or dynamite in every cell (dynamite is 1 in 9)
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        var r = random.Next(9);
                        if (r < 2)
                        {
                            fruits[row, col] = "A";
                        }
                        else if (r < 4)
                        {
                            fruits[row, col] = "B";
                        }
                        else if (r < 6)
                        {
                            fruits[row, col] = "O";
                        }
                        else if (r < 8)
                        {
                            fruits[row, col] = "K";
                        }
                        else
                        {
                            fruits[row, col] = "D";
                        }
                    }
                }

                score = 0;
                gameOver = false;
                needNewBoard = false;
            }

            // Draw the board
            Console.WriteLine();
            Console.WriteLine("1 2 3 4 5 6 7 8 9");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(fruits[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Score: {score}");

            if (gameOver)
            {
                Console.WriteLine("BOOM! You hit the dynamite. Game over!");
            }

            Console.Write("Fire from (t)op or (b)ottom, (n)ew game or (q)uit: ");
            var command = Console.ReadLine();

            if (command == "q")
            {
                break;
            }

            if (command == "n")
            {
                needNewBoard = true;
                continue;
            }

            if (gameOver || (command != "t" && command != "b"))
            {
                continue;
            }

            Console.Write("Column (1-9): ");
            var column = int.Parse(Console.ReadLine()) - 1;

            // Aiming is not perfect: move the shot -1, 0 or +1 columns
            column = column + random.Next(-1, 2);
            if (column < 0)
            {
                column = 0;
            }
            if (column > cols - 1)
            {
                column = cols - 1;
            }

            // From the top we go down (+1), from the bottom we go up (-1)
            var currentRow = 0;
            var step = 1;
            if (command == "b")
            {
                currentRow = rows - 1;
                step = -1;
            }

            while (currentRow >= 0 && currentRow < rows)
            {
                var fruit = fruits[currentRow, column];

                if (fruit == "D")
                {
                    gameOver = true;
                    break;
                }

                if (fruit != ".")
                {
                    score++;
                    fruits[currentRow, column] = ".";  // the fruit is gone
                    break;
                }

                currentRow = currentRow + step;
            }
        }
    }
}
