using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace C_sharp_school_introduction.Helpers;

// A tiny "turtle graphics" helper, used by the turtle drawing exercises in Lesson 5.1.
// The book uses the Nakov.TurtleGraphics library, which works only in Windows Forms.
// This turtle works the same way (Forward, Rotate, PenColor, Reset) on any computer:
// ShowDrawing() saves the picture as an .svg file and opens it in your web browser.
public static class Turtle
{
    private static double x;
    private static double y;
    private static double angle;  // 0 means "looking up", positive angles turn right
    private static readonly List<string> lines = new();

    public static string PenColor { get; set; } = "blue";

    public static void Reset()
    {
        x = 0;
        y = 0;
        angle = 0;
        PenColor = "blue";
        lines.Clear();
    }

    public static void Rotate(double degrees)
    {
        angle = angle + degrees;
    }

    public static void Forward(double distance)
    {
        var radians = angle * Math.PI / 180;
        var newX = x + distance * Math.Sin(radians);
        var newY = y - distance * Math.Cos(radians);

        lines.Add(string.Format(CultureInfo.InvariantCulture,
            "<line x1=\"{0:0.##}\" y1=\"{1:0.##}\" x2=\"{2:0.##}\" y2=\"{3:0.##}\" stroke=\"{4}\" />",
            x, y, newX, newY, PenColor));

        x = newX;
        y = newY;
    }

    public static void Backward(double distance)
    {
        Rotate(180);
        Forward(distance);
        Rotate(180);
    }

    public static void ShowDrawing(string name)
    {
        var svg = new StringBuilder();
        svg.AppendLine("<svg xmlns=\"http://www.w3.org/2000/svg\" viewBox=\"-400 -400 800 800\" width=\"800\" height=\"800\">");
        svg.AppendLine("<rect x=\"-400\" y=\"-400\" width=\"800\" height=\"800\" fill=\"white\" />");
        svg.AppendLine("<g stroke-width=\"5\" stroke-linecap=\"round\">");
        foreach (var line in lines)
        {
            svg.AppendLine(line);
        }
        svg.AppendLine("</g>");
        svg.AppendLine("</svg>");

        var path = Path.Combine(Path.GetTempPath(), name + ".svg");
        File.WriteAllText(path, svg.ToString());
        Console.WriteLine($"The drawing is saved in: {path}");

        try
        {
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
        }
        catch
        {
            Console.WriteLine("Open the file in your web browser to see it.");
        }
    }
}
