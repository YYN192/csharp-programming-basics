namespace C_sharp_school_introduction.Lesson10_Methods;

// Problem: Notifications
// Read n, then n messages. Each message starts with its type:
//  - success: then read an operation and a message
//  - warning: then read a message
//  - error:   then read an operation, a message and an error code
// Print each message in its own format, with a line of "=" as long as the title,
// and an empty line after it.
public static class Notifications
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            ReadAndProcessMessage();
        }
    }

    private static void ReadAndProcessMessage()
    {
        var messageType = Console.ReadLine();

        if (messageType == "success")
        {
            var operation = Console.ReadLine();
            var message = Console.ReadLine();
            ShowSuccessMessage(operation, message);
        }
        else if (messageType == "warning")
        {
            var message = Console.ReadLine();
            ShowWarningMessage(message);
        }
        else if (messageType == "error")
        {
            var operation = Console.ReadLine();
            var message = Console.ReadLine();
            var errorCode = int.Parse(Console.ReadLine());
            ShowErrorMessage(operation, message, errorCode);
        }
    }

    private static void ShowSuccessMessage(string operation, string message)
    {
        var title = $"Successfully executed {operation}.";
        Console.WriteLine(title);
        Console.WriteLine(new string('=', title.Length));
        Console.WriteLine($"{message}.");
        Console.WriteLine();
    }

    private static void ShowWarningMessage(string message)
    {
        var title = $"Warning: {message}.";
        Console.WriteLine(title);
        Console.WriteLine(new string('=', title.Length));
        Console.WriteLine();
    }

    private static void ShowErrorMessage(string operation, string message, int errorCode)
    {
        var title = $"Error: Failed to execute {operation}.";
        Console.WriteLine(title);
        Console.WriteLine(new string('=', title.Length));
        Console.WriteLine($"Reason: {message}.");
        Console.WriteLine($"Error code: {errorCode}.");
        Console.WriteLine();
    }
}
