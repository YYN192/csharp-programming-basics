namespace C_sharp_school_introduction.Lesson02_2_SimpleCalculationsExam;

// Exam problem: Training Lab
// A hall is l x w meters. One working place is 70 x 120 cm.
// In the middle there is a 100 cm wide hallway. The door and the podium take 3 places.
// Print how many working places fit in the hall.
public static class TrainingLab
{
    public static void Run()
    {
        var length = double.Parse(Console.ReadLine());
        var width = double.Parse(Console.ReadLine());

        // Work in centimeters and keep only the whole part (we can't have half a desk).
        var rows = Math.Truncate(length * 100 / 120);
        var placesPerRow = Math.Truncate((width * 100 - 100) / 70);

        var places = rows * placesPerRow - 3;

        Console.WriteLine(places);
    }
}
