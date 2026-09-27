namespace C_sharp_school_introduction.Lesson03_1_SimpleConditions;

// Problem: Excellent Grade
// Read a grade and print "Excellent!" if it is 5.50 or higher.
public static class ExcellentGrade
{
    public static void Run()
    {
        var grade = double.Parse(Console.ReadLine());

        if (grade >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
    }
}
