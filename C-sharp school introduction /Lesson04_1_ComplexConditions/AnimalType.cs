namespace C_sharp_school_introduction.Lesson04_1_ComplexConditions;

// Example: Animal Type (switch-case with several labels)
// dog -> mammal; crocodile, tortoise, snake -> reptile; anything else -> unknown
public static class AnimalType
{
    public static void Run()
    {
        var animal = Console.ReadLine();

        switch (animal)
        {
            case "dog":
                Console.WriteLine("mammal");
                break;
            case "crocodile":
            case "tortoise":
            case "snake":
                Console.WriteLine("reptile");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}
