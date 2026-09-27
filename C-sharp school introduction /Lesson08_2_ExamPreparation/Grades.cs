namespace C_sharp_school_introduction.Lesson08_2_ExamPreparation;

// Exam problem: Grades
// Read the number of students and the grade of each student (2.00 to 6.00).
// Print the percent of top students (5.00 or more), of grades 4.00-4.99, of grades 3.00-3.99,
// of fails (under 3.00), and the average grade.
public static class Grades
{
    public static void Run()
    {
        var students = int.Parse(Console.ReadLine());
        var topStudents = 0;
        var between4And5 = 0;
        var between3And4 = 0;
        var fails = 0;
        var sumOfGrades = 0.0;

        for (int i = 0; i < students; i++)
        {
            var grade = double.Parse(Console.ReadLine());
            sumOfGrades = sumOfGrades + grade;

            if (grade >= 5.00)
            {
                topStudents++;
            }
            else if (grade >= 4.00)
            {
                between4And5++;
            }
            else if (grade >= 3.00)
            {
                between3And4++;
            }
            else
            {
                fails++;
            }
        }

        Console.WriteLine($"Top students: {topStudents * 100.0 / students:f2}%");
        Console.WriteLine($"Between 4.00 and 4.99: {between4And5 * 100.0 / students:f2}%");
        Console.WriteLine($"Between 3.00 and 3.99: {between3And4 * 100.0 / students:f2}%");
        Console.WriteLine($"Fail: {fails * 100.0 / students:f2}%");
        Console.WriteLine($"Average: {sumOfGrades / students:f2}");
    }
}
