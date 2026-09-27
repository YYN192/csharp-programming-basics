namespace C_sharp_school_introduction.Lesson03_1_SimpleConditions;

// Problem: Time + 15 Minutes
// Read hours (0-23) and minutes (0-59) and print the time after 15 minutes as h:mm.
public static class TimePlus15Minutes
{
    public static void Run()
    {
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());

        // Turn everything into minutes, add 15, then split it back
        var totalMinutes = hours * 60 + minutes + 15;
        var newHours = totalMinutes / 60;
        var newMinutes = totalMinutes % 60;

        // After 23:59 comes 0:00
        if (newHours == 24)
        {
            newHours = 0;
        }

        if (newMinutes < 10)
        {
            Console.WriteLine($"{newHours}:0{newMinutes}");
        }
        else
        {
            Console.WriteLine($"{newHours}:{newMinutes}");
        }
    }
}
