namespace C_sharp_school_introduction.Lesson10_Methods;

// Example: Empty Cash Receipt
// Print an empty cash receipt. PrintReceipt calls three smaller methods:
// one for the header, one for the body and one for the footer.
public static class EmptyReceipt
{
    public static void Run()
    {
        PrintReceipt();
    }

    private static void PrintReceipt()
    {
        PrintReceiptHeader();
        PrintReceiptBody();
        PrintReceiptFooter();
    }

    private static void PrintReceiptHeader()
    {
        Console.WriteLine("CASH RECEIPT");
        Console.WriteLine("------------------------------");
    }

    private static void PrintReceiptBody()
    {
        Console.WriteLine("Charged to____________________");
        Console.WriteLine("Received by___________________");
    }

    private static void PrintReceiptFooter()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("(c) SoftUni");
    }
}
