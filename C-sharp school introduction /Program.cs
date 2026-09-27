using System.Globalization;

namespace C_sharp_school_introduction;

// Start here! Run the project, pick a lesson, then pick an exercise to run it.
// Every exercise lives in its own file inside a "LessonXX_..." folder.
public static class Program
{
    public static void Main()
    {
        // Always use "." for decimal numbers (2.5, not 2,5), just like the SoftUni Judge.
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Lessons:");
            for (int i = 0; i < Lessons.All.Length; i++)
            {
                Console.WriteLine($"  {i + 1}. {Lessons.All[i].Name}");
            }

            Console.Write("Choose a lesson (or press Enter to quit): ");
            var lessonInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(lessonInput))
            {
                break;
            }

            var lessonIndex = int.Parse(lessonInput) - 1;
            var lesson = Lessons.All[lessonIndex];

            Console.WriteLine();
            Console.WriteLine(lesson.Name);
            for (int i = 0; i < lesson.Exercises.Length; i++)
            {
                Console.WriteLine($"  {i + 1}. {lesson.Exercises[i].Name}");
            }

            Console.Write("Choose an exercise: ");
            var exerciseIndex = int.Parse(Console.ReadLine()) - 1;
            var exercise = lesson.Exercises[exerciseIndex];

            Console.WriteLine($"--- {exercise.Name} --- (type the input, press Enter after each line)");
            exercise.Run();
        }
    }
}
