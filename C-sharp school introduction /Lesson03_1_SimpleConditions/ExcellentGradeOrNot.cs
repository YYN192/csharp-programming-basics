namespace C_sharp_school_introduction.Lesson03_1_SimpleConditions;

// Problem: Excellent Grade or Not
// Read a grade and print "Excellent!" if it is 5.50 or higher, otherwise "Not excellent."
public static class ExcellentGradeOrNot
{
    public static void Run()
    {
        var grade = double.Parse(Console.ReadLine());

        if (grade >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}
