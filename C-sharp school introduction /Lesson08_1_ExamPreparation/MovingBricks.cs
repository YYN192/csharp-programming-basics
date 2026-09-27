namespace C_sharp_school_introduction.Lesson08_1_ExamPreparation;

// Exam problem: Moving Bricks
// x bricks must be moved by w workers. Each worker's cart holds m bricks.
// Print the smallest number of trips they need to make.
public static class MovingBricks
{
    public static void Run()
    {
        var bricks = int.Parse(Console.ReadLine());
        var workers = int.Parse(Console.ReadLine());
        var cartCapacity = int.Parse(Console.ReadLine());

        var bricksPerTrip = workers * cartCapacity;

        // Round up: even a half-full last trip is still a trip
        var trips = Math.Ceiling((double)bricks / bricksPerTrip);

        Console.WriteLine(trips);
    }
}
