# Programming Basics with C# – all exercises

Solutions to every example, exercise, exam problem and lab in the book
**"Основи на програмирането със C#" (Programming Basics with C#, Svetlin Nakov, 2017)**.

## How to run

Run the project in Rider (or `dotnet run`). A menu asks for a chapter, then for an exercise.
Type the input and press Enter after each line, just like in the SoftUni Judge.

## How it is organized

All code is in the `C-sharp school introduction` project folder:

- One folder per chapter: `Lesson01_FirstSteps`, `Lesson02_1_SimpleCalculations`, ... `Lesson11_TricksAndHacks`.
- One file per exercise. The `Run()` method in each file is the exercise's `Main` method.
  To send a solution to the Judge, copy the body of `Run()` (plus any helper methods in
  Chapter 10) into a normal `static void Main()`.
- `Program.cs` holds the menu, and `Lessons.cs` lists all exercises in the book's order.
- Solutions stick to what the book has taught up to that chapter. For example, Chapter 1
  has no loops and methods show up only in Chapter 10. The exceptions are the `*` problems
  and the labs, which the book says go further on purpose.

## Notes

- **Decimal point:** `Program.cs` sets the culture to invariant, so `2.5` works (not `2,5`),
  like the Judge expects.
- **GUI and web labs** (Summator, BGN to EUR, Catch the Button, Currency Converter, Point and
  Rectangle, Ratings, Shoot the Fruits) need Windows Forms / ASP.NET MVC in the book.
  They are written here as console programs with the same logic, so they run on macOS too.
- **Turtle graphics** (Chapter 5.1) use a small helper, `Helpers/Turtle.cs`, with the same
  commands as the book's library (`Forward`, `Rotate`, `PenColor`, `Reset`). It saves the
  drawing as an `.svg` file and opens it in your browser.
- **Long decimals:** the 2017 book shows numbers like `28.2743338823081`. Modern .NET prints
  more digits (`28.274333882308138`). The value is the same.
- **Book typos:** a few sample outputs in the book don't match its own problem statement
  (`Pipe2` in Pipes in Pool, a missing `more` in Sleepy Tom Cat, `Yes!99` in Firm, the last line
  of Stop Sign for n = 6, one letter in String Encryption). The code follows the statement.
