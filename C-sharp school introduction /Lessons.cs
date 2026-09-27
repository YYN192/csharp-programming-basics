namespace C_sharp_school_introduction;

// The list of all lessons and their exercises, in the order of the book.
// It is used only by the menu in Program.cs.
public record Exercise(string Name, Action Run);

public record Lesson(string Name, Exercise[] Exercises);

public static class Lessons
{
    public static readonly Lesson[] All =
    {
        new("Chapter 1: First Steps in Programming", new Exercise[]
        {
            new("Example: Play the note A", Lesson01_FirstSteps.PlayNoteA.Run),
            new("Example: Play a sequence of notes", Lesson01_FirstSteps.PlayNotesSequence.Run),
            new("Example: Leva to euro", Lesson01_FirstSteps.LevaToEuro.Run),
            new("Example: Hello C#", Lesson01_FirstSteps.HelloCSharp.Run),
            new("Expression", Lesson01_FirstSteps.Expression.Run),
            new("Numbers from 1 to 20", Lesson01_FirstSteps.NumbersFrom1To20.Run),
            new("Triangle of 55 stars", Lesson01_FirstSteps.TriangleOf55Stars.Run),
            new("Rectangle area", Lesson01_FirstSteps.RectangleArea.Run),
            new("* Square of stars", Lesson01_FirstSteps.SquareOfStars.Run),
            new("Lab: Summator (sum of two numbers)", Lesson01_FirstSteps.NumberSummator.Run),
        }),
        new("Chapter 2.1: Simple Calculations", new Exercise[]
        {
            new("Square area", Lesson02_1_SimpleCalculations.SquareArea.Run),
            new("Inches to centimeters", Lesson02_1_SimpleCalculations.InchesToCentimeters.Run),
            new("Greeting by name", Lesson02_1_SimpleCalculations.GreetingByName.Run),
            new("Concatenate text and numbers", Lesson02_1_SimpleCalculations.ConcatenateData.Run),
            new("Trapezoid area", Lesson02_1_SimpleCalculations.TrapezoidArea.Run),
            new("Circle area and perimeter", Lesson02_1_SimpleCalculations.CircleAreaAndPerimeter.Run),
            new("Rectangle area in the plane", Lesson02_1_SimpleCalculations.RectangleInPlane.Run),
            new("Triangle area", Lesson02_1_SimpleCalculations.TriangleArea.Run),
            new("Celsius to Fahrenheit", Lesson02_1_SimpleCalculations.CelsiusToFahrenheit.Run),
            new("Radians to degrees", Lesson02_1_SimpleCalculations.RadiansToDegrees.Run),
            new("USD to BGN", Lesson02_1_SimpleCalculations.UsdToBgn.Run),
            new("* Currency converter", Lesson02_1_SimpleCalculations.CurrencyConverter.Run),
            new("** 1000 days on the Earth", Lesson02_1_SimpleCalculations.ThousandDaysOnEarth.Run),
            new("Lab: BGN to EUR converter", Lesson02_1_SimpleCalculations.BgnToEurConverter.Run),
            new("Lab: *** Catch the button", Lesson02_1_SimpleCalculations.CatchTheButton.Run),
        }),
        new("Chapter 2.2: Simple Calculations - Exam Problems", new Exercise[]
        {
            new("Training lab", Lesson02_2_SimpleCalculationsExam.TrainingLab.Run),
            new("Vegetable market", Lesson02_2_SimpleCalculationsExam.VegetableMarket.Run),
            new("Change tiles", Lesson02_2_SimpleCalculationsExam.ChangeTiles.Run),
            new("Money", Lesson02_2_SimpleCalculationsExam.Money.Run),
            new("Daily earnings", Lesson02_2_SimpleCalculationsExam.DailyEarnings.Run),
        }),
        new("Chapter 3.1: Simple Conditions", new Exercise[]
        {
            new("Excellent grade", Lesson03_1_SimpleConditions.ExcellentGrade.Run),
            new("Excellent grade or not", Lesson03_1_SimpleConditions.ExcellentGradeOrNot.Run),
            new("Even or odd", Lesson03_1_SimpleConditions.EvenOrOdd.Run),
            new("Greater number", Lesson03_1_SimpleConditions.GreaterNumber.Run),
            new("Digit in words", Lesson03_1_SimpleConditions.DigitInWords.Run),
            new("Bonus score", Lesson03_1_SimpleConditions.BonusScore.Run),
            new("Guess the password", Lesson03_1_SimpleConditions.GuessThePassword.Run),
            new("Summing up seconds", Lesson03_1_SimpleConditions.SumSeconds.Run),
            new("Metric converter", Lesson03_1_SimpleConditions.MetricConverter.Run),
            new("Number from 100 to 200", Lesson03_1_SimpleConditions.Number100To200.Run),
            new("Equal words", Lesson03_1_SimpleConditions.EqualWords.Run),
            new("Speed info", Lesson03_1_SimpleConditions.SpeedInfo.Run),
            new("Areas of figures", Lesson03_1_SimpleConditions.AreaOfFigures.Run),
            new("Time + 15 minutes", Lesson03_1_SimpleConditions.TimePlus15Minutes.Run),
            new("Equal 3 numbers", Lesson03_1_SimpleConditions.EqualNumbers.Run),
            new("* Number 0 to 100 in words", Lesson03_1_SimpleConditions.NumberToWords.Run),
            new("Lab: Currency converter", Lesson03_1_SimpleConditions.CurrencyConverterApp.Run),
        }),
        new("Chapter 3.2: Simple Conditions - Exam Problems", new Exercise[]
        {
            new("Transport price", Lesson03_2_SimpleConditionsExam.TransportPrice.Run),
            new("Pipes in a pool", Lesson03_2_SimpleConditionsExam.PipesInPool.Run),
            new("Sleepy Tom cat", Lesson03_2_SimpleConditionsExam.SleepyTomCat.Run),
            new("Harvest", Lesson03_2_SimpleConditionsExam.Harvest.Run),
            new("Firm", Lesson03_2_SimpleConditionsExam.Firm.Run),
        }),
        new("Chapter 4.1: More Complex Conditions", new Exercise[]
        {
            new("Example: Personal titles", Lesson04_1_ComplexConditions.PersonalTitles.Run),
            new("Example: Small shop", Lesson04_1_ComplexConditions.SmallShop.Run),
            new("Example: Point in a rectangle", Lesson04_1_ComplexConditions.PointInRectangle.Run),
            new("Example: Fruit or vegetable", Lesson04_1_ComplexConditions.FruitOrVegetable.Run),
            new("Example: Invalid number", Lesson04_1_ComplexConditions.InvalidNumber.Run),
            new("Example: Point on a rectangle border", Lesson04_1_ComplexConditions.PointOnRectangleBorder.Run),
            new("Example: Fruit shop", Lesson04_1_ComplexConditions.FruitShop.Run),
            new("Example: Trade commissions", Lesson04_1_ComplexConditions.TradeCommissions.Run),
            new("Example: Day of the week", Lesson04_1_ComplexConditions.DayOfWeekName.Run),
            new("Example: Animal type", Lesson04_1_ComplexConditions.AnimalType.Run),
            new("Cinema", Lesson04_1_ComplexConditions.Cinema.Run),
            new("Volleyball", Lesson04_1_ComplexConditions.Volleyball.Run),
            new("* Point in the figure", Lesson04_1_ComplexConditions.PointInTheFigure.Run),
            new("Lab: * Point and rectangle", Lesson04_1_ComplexConditions.PointAndRectangleApp.Run),
        }),
        new("Chapter 4.2: More Complex Conditions - Exam Problems", new Exercise[]
        {
            new("On time for the exam", Lesson04_2_ComplexConditionsExam.OnTimeForExam.Run),
            new("Trip", Lesson04_2_ComplexConditionsExam.Trip.Run),
            new("Operations between numbers", Lesson04_2_ComplexConditionsExam.OperationsBetweenNumbers.Run),
            new("Match tickets", Lesson04_2_ComplexConditionsExam.MatchTickets.Run),
            new("Hotel room", Lesson04_2_ComplexConditionsExam.HotelRoom.Run),
        }),
        new("Chapter 5.1: Loops", new Exercise[]
        {
            new("Example: Numbers from 1 to 100", Lesson05_1_Loops.NumbersFrom1To100.Run),
            new("Example: Numbers ending in 7", Lesson05_1_Loops.NumbersEndingIn7.Run),
            new("Example: All Latin letters", Lesson05_1_Loops.LatinLetters.Run),
            new("Summing up numbers", Lesson05_1_Loops.SumNumbers.Run),
            new("Max number", Lesson05_1_Loops.MaxNumber.Run),
            new("Min number", Lesson05_1_Loops.MinNumber.Run),
            new("Left and right sum", Lesson05_1_Loops.LeftAndRightSum.Run),
            new("Even / odd sum", Lesson05_1_Loops.EvenOddSum.Run),
            new("Sum of vowels", Lesson05_1_Loops.VowelsSum.Run),
            new("Element equal to the sum of the rest", Lesson05_1_Loops.HalfSumElement.Run),
            new("Even / odd positions", Lesson05_1_Loops.EvenOddPositions.Run),
            new("Equal pairs", Lesson05_1_Loops.EqualPairs.Run),
            new("Lab: Drawing with a turtle", Lesson05_1_Loops.DrawWithTurtle.Run),
            new("Lab: * Turtle hexagon", Lesson05_1_Loops.TurtleHexagon.Run),
            new("Lab: * Turtle star", Lesson05_1_Loops.TurtleStar.Run),
            new("Lab: * Turtle spiral", Lesson05_1_Loops.TurtleSpiral.Run),
            new("Lab: * Turtle sun", Lesson05_1_Loops.TurtleSun.Run),
            new("Lab: * Turtle spiral triangles", Lesson05_1_Loops.TurtleSpiralTriangles.Run),
        }),
        new("Chapter 5.2: Loops - Exam Problems", new Exercise[]
        {
            new("Histogram", Lesson05_2_LoopsExam.Histogram.Run),
            new("Smart Lily", Lesson05_2_LoopsExam.SmartLily.Run),
            new("Back to the past", Lesson05_2_LoopsExam.BackToThePast.Run),
            new("Hospital", Lesson05_2_LoopsExam.Hospital.Run),
            new("Division without remainder", Lesson05_2_LoopsExam.DivisionWithoutRemainder.Run),
            new("Logistics", Lesson05_2_LoopsExam.Logistics.Run),
        }),
        new("Chapter 6.1: Nested Loops", new Exercise[]
        {
            new("Example: Rectangle of 10 x 10 stars", Lesson06_1_NestedLoops.Rectangle10x10.Run),
            new("Example: Rectangle of N x N stars", Lesson06_1_NestedLoops.RectangleNxN.Run),
            new("Example: Square of stars", Lesson06_1_NestedLoops.SquareOfStars.Run),
            new("Example: Triangle of dollars", Lesson06_1_NestedLoops.TriangleOfDollars.Run),
            new("Example: Square frame", Lesson06_1_NestedLoops.SquareFrame.Run),
            new("Rhombus of stars", Lesson06_1_NestedLoops.RhombusOfStars.Run),
            new("Christmas tree", Lesson06_1_NestedLoops.ChristmasTree.Run),
            new("Sunglasses", Lesson06_1_NestedLoops.Sunglasses.Run),
            new("House", Lesson06_1_NestedLoops.House.Run),
            new("Diamond", Lesson06_1_NestedLoops.Diamond.Run),
            new("Lab: Ratings", Lesson06_1_NestedLoops.RatingsApp.Run),
        }),
        new("Chapter 6.2: Nested Loops - Exam Problems", new Exercise[]
        {
            new("Draw a fort", Lesson06_2_NestedLoopsExam.Fort.Run),
            new("Butterfly", Lesson06_2_NestedLoopsExam.Butterfly.Run),
            new("Stop sign", Lesson06_2_NestedLoopsExam.StopSign.Run),
            new("Arrow", Lesson06_2_NestedLoopsExam.Arrow.Run),
            new("Axe", Lesson06_2_NestedLoopsExam.Axe.Run),
        }),
        new("Chapter 7.1: More Complex Loops", new Exercise[]
        {
            new("Example: Numbers 1 to N with step 3", Lesson07_1_ComplexLoops.NumbersStep3.Run),
            new("Example: Numbers N to 1", Lesson07_1_ComplexLoops.NumbersNTo1.Run),
            new("Example: Numbers 1 to 2^n", Lesson07_1_ComplexLoops.PowersOfTwo.Run),
            new("Example: Even powers of 2", Lesson07_1_ComplexLoops.EvenPowersOfTwo.Run),
            new("Example: Sequence 2k + 1", Lesson07_1_ComplexLoops.Sequence2kPlus1.Run),
            new("Example: Number in range 1...100", Lesson07_1_ComplexLoops.NumberInRange1To100.Run),
            new("Example: Greatest common divisor", Lesson07_1_ComplexLoops.GreatestCommonDivisor.Run),
            new("Example: Factorial", Lesson07_1_ComplexLoops.Factorial.Run),
            new("Example: Sum of digits", Lesson07_1_ComplexLoops.SumOfDigits.Run),
            new("Example: Prime number check", Lesson07_1_ComplexLoops.PrimeCheck.Run),
            new("Example: Enter an even number", Lesson07_1_ComplexLoops.EnterEvenNumber.Run),
            new("Example: Nested loops and break", Lesson07_1_ComplexLoops.NestedLoopsAndBreak.Run),
            new("Example: Invalid numbers with try-catch", Lesson07_1_ComplexLoops.EvenNumberTryCatch.Run),
            new("Fibonacci numbers", Lesson07_1_ComplexLoops.Fibonacci.Run),
            new("Number pyramid", Lesson07_1_ComplexLoops.NumberPyramid.Run),
            new("Number table", Lesson07_1_ComplexLoops.NumberTable.Run),
            new("Lab: Shoot the fruits game", Lesson07_1_ComplexLoops.FruitGame.Run),
        }),
        new("Chapter 7.2: More Complex Loops - Exam Problems", new Exercise[]
        {
            new("Dumb passwords generator", Lesson07_2_ComplexLoopsExam.DumbPasswords.Run),
            new("Magic numbers", Lesson07_2_ComplexLoopsExam.MagicNumbers.Run),
            new("Stop number", Lesson07_2_ComplexLoopsExam.StopNumber.Run),
            new("Special numbers", Lesson07_2_ComplexLoopsExam.SpecialNumbers.Run),
            new("Digits", Lesson07_2_ComplexLoopsExam.Digits.Run),
        }),
        new("Chapter 8.1: Exam Preparation - Part I", new Exercise[]
        {
            new("Triangle area in the plane", Lesson08_1_ExamPreparation.TriangleAreaInPlane.Run),
            new("Moving bricks", Lesson08_1_ExamPreparation.MovingBricks.Run),
            new("Point on a segment", Lesson08_1_ExamPreparation.PointOnSegment.Run),
            new("Point in a figure", Lesson08_1_ExamPreparation.PointInFigure.Run),
            new("Date after 5 days", Lesson08_1_ExamPreparation.DateAfter5Days.Run),
            new("Sums of 3 numbers", Lesson08_1_ExamPreparation.SumsOf3Numbers.Run),
            new("Sums with step 3", Lesson08_1_ExamPreparation.SumsStep3.Run),
            new("Increasing elements", Lesson08_1_ExamPreparation.IncreasingElements.Run),
            new("Perfect diamond", Lesson08_1_ExamPreparation.PerfectDiamond.Run),
            new("Rectangle with stars", Lesson08_1_ExamPreparation.RectangleWithStars.Run),
            new("Increasing 4 numbers", Lesson08_1_ExamPreparation.Increasing4Numbers.Run),
            new("Generating rectangles", Lesson08_1_ExamPreparation.GeneratingRectangles.Run),
        }),
        new("Chapter 8.2: Exam Preparation - Part II", new Exercise[]
        {
            new("Distance", Lesson08_2_ExamPreparation.Distance.Run),
            new("Changing tiles", Lesson08_2_ExamPreparation.ChangingTiles.Run),
            new("Flower shop", Lesson08_2_ExamPreparation.FlowerShop.Run),
            new("Grades", Lesson08_2_ExamPreparation.Grades.Run),
            new("Christmas hat", Lesson08_2_ExamPreparation.ChristmasHat.Run),
            new("Letter combinations", Lesson08_2_ExamPreparation.LetterCombinations.Run),
        }),
        new("Chapter 9.1: Problems for Champions - Part I", new Exercise[]
        {
            new("Crossing sequences", Lesson09_1_ChampionsPart1.CrossingSequences.Run),
            new("Magic dates", Lesson09_1_ChampionsPart1.MagicDates.Run),
            new("Five special letters", Lesson09_1_ChampionsPart1.FiveSpecialLetters.Run),
        }),
        new("Chapter 9.2: Problems for Champions - Part II", new Exercise[]
        {
            new("Passion shopping days", Lesson09_2_ChampionsPart2.PassionShoppingDays.Run),
            new("Numerical expression", Lesson09_2_ChampionsPart2.NumericalExpression.Run),
            new("Bulls and cows", Lesson09_2_ChampionsPart2.BullsAndCows.Run),
        }),
        new("Chapter 10: Methods", new Exercise[]
        {
            new("Example: Empty cash receipt", Lesson10_Methods.EmptyReceipt.Run),
            new("Example: Sign of a number", Lesson10_Methods.SignOfNumber.Run),
            new("Example: Optional parameters", Lesson10_Methods.OptionalParameters.Run),
            new("Example: Print a triangle", Lesson10_Methods.PrintTriangle.Run),
            new("Example: Filled square", Lesson10_Methods.FilledSquare.Run),
            new("Example: Returning values", Lesson10_Methods.ReturnValues.Run),
            new("Example: Triangle area", Lesson10_Methods.TriangleArea.Run),
            new("Example: Power of a number", Lesson10_Methods.PowerOfNumber.Run),
            new("Example: Returning several values", Lesson10_Methods.ReturnMultipleValues.Run),
            new("Example: Greater of two values (overloading)", Lesson10_Methods.GreaterOfTwoValues.Run),
            new("Example: Local functions", Lesson10_Methods.LocalFunctions.Run),
            new("Hello, Name!", Lesson10_Methods.HelloName.Run),
            new("Min method", Lesson10_Methods.MinMethod.Run),
            new("String repeater", Lesson10_Methods.StringRepeater.Run),
            new("N-th digit", Lesson10_Methods.NthDigit.Run),
            new("Integer to base", Lesson10_Methods.IntegerToBase.Run),
            new("Notifications", Lesson10_Methods.Notifications.Run),
            new("Numbers to words", Lesson10_Methods.NumbersToWords.Run),
            new("String encryption", Lesson10_Methods.StringEncryption.Run),
        }),
        new("Chapter 11: Tricks and Hacks", new Exercise[]
        {
            new("Placeholders", Lesson11_TricksAndHacks.Placeholders.Run),
            new("Rounding", Lesson11_TricksAndHacks.Rounding.Run),
            new("Debugging a loop", Lesson11_TricksAndHacks.DebuggingLoop.Run),
        }),
    };
}
