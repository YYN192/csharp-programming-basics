namespace C_sharp_school_introduction.Lesson04_1_ComplexConditions;

// Example: Personal Titles
// Read an age and a gender (m / f) and print the right title:
// "Mr." (man, 16 or older), "Master" (boy under 16), "Ms." (woman, 16 or older), "Miss" (girl under 16)
public static class PersonalTitles
{
    public static void Run()
    {
        var age = double.Parse(Console.ReadLine());
        var gender = Console.ReadLine();

        if (gender == "m")
        {
            if (age >= 16)
            {
                Console.WriteLine("Mr.");
            }
            else
            {
                Console.WriteLine("Master");
            }
        }
        else if (gender == "f")
        {
            if (age >= 16)
            {
                Console.WriteLine("Ms.");
            }
            else
            {
                Console.WriteLine("Miss");
            }
        }
    }
}
