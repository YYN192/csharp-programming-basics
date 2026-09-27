namespace C_sharp_school_introduction.Lesson03_1_SimpleConditions;

// Problem: Guess the Password
// Read a password and print "Welcome" if it is "s3cr3t!P@ssw0rd", otherwise "Wrong password!"
public static class GuessThePassword
{
    public static void Run()
    {
        var password = Console.ReadLine();

        if (password == "s3cr3t!P@ssw0rd")
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}
